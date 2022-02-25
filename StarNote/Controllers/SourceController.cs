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
    public class SourceController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public SourceController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetPayment")]
        [HttpGet]
        public IEnumerable<GLPaymenttype> GetPayment()
        {
            IEnumerable<GLPaymenttype> response = new List<GLPaymenttype>();
            response = unitOfWork.GLPaymenttypeRepository.GetAll();
            return response;
        }

        [Route("GetProcess")]
        [HttpGet]
        public IEnumerable<GLProcesstype> GetProcess()
        {
            IEnumerable<GLProcesstype> response = new List<GLProcesstype>();
            response = unitOfWork.GLProcesstypeRepository.GetAll();
            return response;
        }
    }
}
