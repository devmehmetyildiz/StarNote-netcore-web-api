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
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public CompanyController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<SPDefinedcompany> GetAll()
        {
            IEnumerable<SPDefinedcompany> list = new List<SPDefinedcompany>();
            list = unitOfWork.SPDefinescompanyRepository.GetAll();
            return list;
        }
        [Route("Add")]
        [HttpPost]
        public bool Add(SPDefinedcompany obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.SPDefinescompanyRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }

        [Route("Update")]
        [HttpPost]
        public bool Update(SPDefinedcompany obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.SPDefinescompanyRepository.update(unitOfWork.SPDefinescompanyRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }

        [Route("Delete")]
        [HttpPost]
        public bool Delete(SPDefinedcompany obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.SPDefinescompanyRepository.update(unitOfWork.SPDefinescompanyRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
    }
}
