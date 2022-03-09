using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarNote.DataAccess;
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
    public class CaseController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public CaseController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<GLCase> GetAll()
        {
            List<GLCase> response = new List<GLCase>();
            response = unitOfWork.GLCaseRespository.GetAll();           
            return response.Where(u => u.Isactive).ToList();
        }

        [Route("GetAllComplate")]
        [HttpGet]
        public IActionResult GetAllComplate()
        {
            List<GLCase> response = new List<GLCase>();
            response = unitOfWork.GLCaseRespository.filteredcases();
            if (response.Count == 0)
                return NotFound();
            return Ok(response.Where(u => u.Isactive).ToList());
        }

        [Route("Add")]
        [HttpPost]
        public bool Add(GLCase obj)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            obj.Guid = newguid.ToString();
            obj.Isactive = true;
            obj.Createdtime = DateTime.Now;
            unitOfWork.GLCaseRespository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("Update")]
        [HttpPost]
        public bool Update(GLCase obj)
        {
            bool Isupdated = false;
            obj.Modifiedtime = DateTime.Now;
            unitOfWork.GLCaseRespository.update(unitOfWork.GLCaseRespository.Getbyid(obj.Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
        [Route("Delete")]
        [HttpDelete]
        public bool Delete(int Id)
        {
            bool Isupdated = false;
            var obj = unitOfWork.GLCaseRespository.Getbyid(Id);
            obj.Deletetime = DateTime.Now;
            obj.Isactive = false;           
            unitOfWork.GLCaseRespository.update(unitOfWork.GLCaseRespository.Getbyid(Id), obj);
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
        }
    }
}
