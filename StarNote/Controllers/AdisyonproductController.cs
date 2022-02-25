using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarNote.DataAccess;
using StarNote.Models.DBModels;
using StarNote.Models.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdisyonproductController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public AdisyonproductController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public List<AdisyonproductModel> GetAll()
        {
            List<AdisyonproductModel> list = new List<AdisyonproductModel>();
            IEnumerable<ADOrderproduct> products = unitOfWork.ADOrderproductRepository.GetAll();
            IEnumerable<ADProductbase> productsbase = unitOfWork.ADProductbaseRepository.GetAll();
            IEnumerable<ADProductoption> productoption = unitOfWork.ADProductoptionRepository.GetAll();
            foreach (var item in products)
            {
                list.Add(new AdisyonproductModel
                {
                    Product = item,
                    Productbase = productsbase.Where(u => u.Productguid == item.Guid).ToList(),
                    Productoption = productoption.Where(u => u.Productguid == item.Guid).ToList()
                });
            }
            return list;
        }
        [Route("Add")]
        [HttpPost]
        public bool Add(AdisyonproductModel obj)
        {

            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Product.Guid = newguid.ToString();
            obj.Product.Isactive = true;
            obj.Product.Createdtime = DateTime.Now;
            unitOfWork.ADOrderproductRepository.Add(obj.Product);
            unitOfWork.ADProductbaseRepository.AddRange(obj.Productbase);
            unitOfWork.ADProductoptionRepository.AddRange(obj.Productoption);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }

        [Route("Update")]
        [HttpPost]
        public bool Update(AdisyonproductModel obj)
        {
            bool Isupdated = false;
            unitOfWork.ADOrderproductRepository.update(unitOfWork.ADOrderproductRepository.Getbyid(obj.Product.Id), obj.Product);
            foreach (var item in obj.Productbase)
            {
                ADProductbase itembase = unitOfWork.ADProductbaseRepository.Getbyid(item.Id);
                if (itembase != null)
                {
                    unitOfWork.ADProductbaseRepository.update(itembase, item);
                }
                else
                    unitOfWork.ADProductbaseRepository.Add(itembase);
            }
            foreach (var item in obj.Productoption)
            {
                ADProductoption itembase = unitOfWork.ADProductoptionRepository.Getbyid(item.Id);
                if (itembase != null)
                {
                    unitOfWork.ADProductoptionRepository.update(itembase, item);
                }
                else
                    unitOfWork.ADProductoptionRepository.Add(itembase);
            }
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }

        [Route("Delete")]
        [HttpPost]
        public bool Delete(AdisyonproductModel obj)
        {
            bool IsDeleted = false;
            obj.Product.Deletetime = DateTime.Now;
            obj.Product.Isactive = false;
            unitOfWork.ADOrderproductRepository.update(unitOfWork.ADOrderproductRepository.Getbyid(obj.Product.Id), obj.Product);
            unitOfWork.ADProductbaseRepository.RemoveRange(obj.Productbase);
            unitOfWork.ADProductoptionRepository.RemoveRange(obj.Productoption);
            if (unitOfWork.Complate() > 0)
            {
                IsDeleted = true;
            }
            return IsDeleted;
        }
        [Route("GetMenus")]
        [HttpGet]
        public IEnumerable<ADMenus> GetMenus()
        {
            IEnumerable<ADMenus> list = new List<ADMenus>();
            list = unitOfWork.ADMenusRepository.GetAll();
            return list;
        }
        [Route("GetStok")]
        [HttpGet]
        public IEnumerable<GLStock> GetStok()
        {
            IEnumerable<GLStock> list = new List<GLStock>();
            list = unitOfWork.GLStockRepository.GetAll();
            return list;
        }
        [Route("GetUnit")]
        [HttpGet]
        public IEnumerable<GLUnit> GetUnit()
        {
            IEnumerable<GLUnit> list = new List<GLUnit>();
            list = unitOfWork.GLUnitRepository.GetAll();
            return list;
        }
        [Route("Deletebaseproduct")]
        [HttpPost]
        public bool Deletebaseproduct(int Id)
        {
            bool IsDeleted = false;
            unitOfWork.ADProductbaseRepository.Remove(Id);
            if (unitOfWork.Complate() > 0)
            {
                IsDeleted = true;
            }
            return IsDeleted;
        }
        [Route("Deletebaseoption")]
        [HttpPost]
        public bool Deletebaseoption(int Id)
        {
            bool IsDeleted = false;
            unitOfWork.ADProductoptionRepository.Remove(Id);
            if (unitOfWork.Complate() > 0)
            {
                IsDeleted = true;
            }
            return IsDeleted;
        }
    }
}
