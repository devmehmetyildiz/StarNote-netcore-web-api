using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarNote.DataAccess;
using StarNote.Models;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdisyonmenusController : ControllerBase
    {     
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
       
        public AdisyonmenusController(ILogger<AdisyonmenusController> logger,Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;            
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<ADMenus> GetAll()
        {
            IEnumerable<ADMenus> list = new List<ADMenus>();
            list = unitOfWork.ADMenusRepository.GetAll();
            return list;
        }

        [Route("Add")]
        [HttpPost]
        public bool Add(ADMenus obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.ADMenusRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("Update")]
        [HttpPost]
        public bool Update(ADMenus obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.ADMenusRepository.update(unitOfWork.ADMenusRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("Delete")]
        [HttpPost]
        public bool Delete(ADMenus obj)
        {
            bool Isupdated = false;
            obj.Isactive = false;
            obj.Deletetime = DateTime.Now;
            unitOfWork.ADMenusRepository.update(unitOfWork.ADMenusRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }

        
    }
}
