using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.DataAccess;
using StarNote.Models.DBModels;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StokController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public StokController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<GLStock> GetAll()
        {
            IEnumerable<GLStock> response = new List<GLStock>();
            response = unitOfWork.GLStockRepository.GetAll();
            return response;
        }

        [Route("Add")]
        [HttpPost]
        public bool Add(GLStock obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLStockRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }

        [Route("Update")]
        [HttpPost]
        public bool Update(GLStock obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLStockRepository.update(unitOfWork.GLStockRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }

        [Route("Delete")]
        [HttpPost]
        public bool Delete(GLStock obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.GLStockRepository.update(unitOfWork.GLStockRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
        [Route("GetSource")]
        [HttpGet]
        public Helperstokclass GetSource()
        {
            Helperstokclass helperclass = new Helperstokclass
            {
                Birim = unitOfWork.GLUnitRepository.GetAll(),
                Kdv = unitOfWork.GLTaxRepository.GetAll(),
                Ürüntür = unitOfWork.GLProducttypeRepository.GetAll()
            };
            return helperclass;
        }
    }
    public class Helperstokclass
    {
        public IEnumerable<GLUnit> Birim { get; set; }
        public IEnumerable<GLTax> Kdv { get; set; }
        public IEnumerable<GLProducttype> Ürüntür { get; set; }
    }

}
