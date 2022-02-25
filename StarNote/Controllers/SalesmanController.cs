using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.DataAccess;
using StarNote.Models.DBModels;
using Microsoft.Extensions.Logging;
using StarNote.Models.UIModels;
using Microsoft.AspNetCore.Authorization;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public SalesmanController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);

        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<GLSalesman> GetAll()
        {
            IEnumerable<GLSalesman> response = new List<GLSalesman>();
            response = unitOfWork.GLSalesmanRepository.GetAll();
            return response;
        }
        [Route("Add")]
        [HttpPost]
        public bool Add(GLSalesman obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLSalesmanRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("Update")]
        [HttpPost]
        public bool Update(GLSalesman obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLSalesmanRepository.update(unitOfWork.GLSalesmanRepository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("Delete")]
        [HttpPost]
        public bool Delete(GLSalesman obj)
        {
            bool Isupdated = false;
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;
            unitOfWork.GLSalesmanRepository.update(unitOfWork.GLSalesmanRepository.Getbyid(obj.Id), obj);
            return Isupdated;
        }
    }
}
