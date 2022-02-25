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
    public class LisanceController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public LisanceController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetLisanceAll")]
        [HttpGet]
        public IEnumerable<GLLisance> GetLisanceAll()
        {
            IEnumerable<GLLisance> response = new List<GLLisance>();
            response = unitOfWork.GLLisanceRepository.GetAll();
            return response;
        }

        [Route("Updatestatus")]
        [HttpPost]
        public List<GLLisance> Updatestatus(int id, string status)
        {
            List<GLLisance> response = new List<GLLisance>();
            //response = dataaccess.GetAll(count);
            return response;
        }
        [Route("AddLisance")]
        [HttpPost]
        public bool AddLisance(GLLisance lisancemodel)
        {
            bool IsAdded = false;
            unitOfWork.GLLisanceRepository.Add(lisancemodel);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
    }
}
