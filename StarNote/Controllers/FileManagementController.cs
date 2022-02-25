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
    public class FileManagementController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public FileManagementController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<SPFilemanagement> Getfilelist()
        {
            IEnumerable<SPFilemanagement> filelist = new List<SPFilemanagement>();
            filelist = unitOfWork.SPFilemanagementRepository.GetAll();
            return filelist;
        }
        [Route("AddFile")]
        [HttpPost]
        public bool AddFile(SPFilemanagement obj)
        {
            bool IsAdded = false;
            unitOfWork.SPFilemanagementRepository.Add(obj);
            if (unitOfWork.Complate() > 0)
                IsAdded = true;
            return IsAdded;
        }
        [Route("Delete")]
        [HttpPost]
        public bool Delete(SPFilemanagement obj)
        {
            bool IsDeleted = false;
            unitOfWork.SPFilemanagementRepository.Remove(obj.Id);
            if (unitOfWork.Complate() > 0)
                IsDeleted = true;
            return IsDeleted;
        }
    }
}
