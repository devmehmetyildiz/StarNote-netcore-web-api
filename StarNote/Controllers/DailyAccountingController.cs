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
    public class DailyAccountingController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;
        public DailyAccountingController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        [Route("GetAll")]
        [HttpGet]
        public List<OrderModel> GetDailyFilters(string startdate, string enddate)
        {
            List<OrderModel> list = new List<OrderModel>();
            List<SPCostumerorder> costumerlist = new List<SPCostumerorder>();
            costumerlist = unitOfWork.SPCostumerorderRepository.GetAllwithRegisterdatefilter(Convert.ToDateTime(startdate), Convert.ToDateTime(enddate));
            foreach (var item in costumerlist)
            {
                List<SPJoborder> joblist = unitOfWork.SPJoborderRepository.GetByIDJobOrders(item.Guid);
                list.Add(new OrderModel { Costumerorder = item, Joborder = joblist });
            }
            return list;
        }
        [Route("Getunit")]
        [HttpGet]
        public List<GLUnit> Getunit()
        {
            return unitOfWork.GLUnitRepository.GetAll();
        }
        [Route("Getpayment")]
        [HttpGet]
        public List<GLPaymenttype> Getpayment()
        {
            return unitOfWork.GLPaymenttypeRepository.GetAll();
        }
        [Route("GetSalesman")]
        [HttpGet]
        public List<GLSalesman> GetSalesman()
        {
            return unitOfWork.GLSalesmanRepository.GetAll();
        }
        [Route("GetStock")]
        [HttpGet]
        public List<GLStock> GetStock()
        {
            return unitOfWork.GLStockRepository.GetAll();
        }
        [Route("GetProcess")]
        [HttpGet]
        public List<GLProcesstype> GetProcess()
        {
            return unitOfWork.GLProcesstypeRepository.GetAll();
        }
    }
}
