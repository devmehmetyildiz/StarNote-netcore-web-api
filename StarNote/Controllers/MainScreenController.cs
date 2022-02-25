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
    public class MainScreenController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;

        public MainScreenController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);            
        }

        [Route("GetMainAll")]
        [HttpGet]
        public List<OrderModel> GetMainAll()
        {            
            List<SPCostumerorder> sPCostumerorders = unitOfWork.SPCostumerorderRepository.GetAll();
            List<SPJoborder> sPJoborders = unitOfWork.SPJoborderRepository.GetAll();
            List<OrderModel> list = new List<OrderModel>();
            foreach (var item in sPCostumerorders)
            {
                list.Add(new OrderModel
                {
                    Costumerorder = item,
                    Joborder = sPJoborders.Where(u => u.Costumerorder == item.Guid).ToList()
                });
            }
            return list;
        }
        [Route("Getselectedjoborders")]
        [HttpGet]
        public List<SPJoborder> Getselectedjoborders(string guid)
        {
            List<SPJoborder> list = new List<SPJoborder>();
            list = unitOfWork.SPJoborderRepository.GetByIDJobOrders(guid);
            return list;
        }
        [Route("GetJobOrder")]
        [HttpGet]
        public string GetJobOrder()
        {
            string response = "";
            //response = dao.Createjoborder();
            return response;
        }
        [Route("Add")]
        [HttpPost]
        public bool Add(OrderModel model)
        {
            bool IsAdded = false;
            Guid newguid = Guid.NewGuid();
            model.Costumerorder.Guid = newguid.ToString();
            foreach (var item in model.Joborder)
            {
                item.Costumerorder = newguid.ToString();
            }
            unitOfWork.SPCostumerorderRepository.Add(model.Costumerorder);
            unitOfWork.SPJoborderRepository.AddRange(model.Joborder);
            if (unitOfWork.Complate() > 0)
            {
                IsAdded = true;
            }
            //if (IsAdded)
            //{
            //    foreach (var item in model.Joborder)
            //    {
            //        StokModel stokmodel = dao.Getselectedstok(item.Ürün);
            //        if (model.Costumerorder.Satışyöntemi == BaseDAO.Satınalma)
            //        {
            //            stokmodel.Miktar += item.Miktar;
            //        }
            //        else
            //        {
            //            stokmodel.Miktar -= item.Miktar;
            //        }
            //        dao.GenericUpdate(stokmodel);
            //    }
            //}                               
            return IsAdded;
        }
        [Route("AddMainSoft")]
        [HttpPost]
        public bool AddMainSoft(OrderModel objmain)
        {
            bool IsAdded = false;
            objmain.Costumerorder.Savetype = 1;
            unitOfWork.SPCostumerorderRepository.Add(objmain.Costumerorder);
            unitOfWork.SPJoborderRepository.AddRange(objmain.Joborder);
            if (unitOfWork.Complate() > 0)
            {
                IsAdded = true;
            }
            return IsAdded;
        }
        [Route("Update")]
        [HttpPost]
        public bool Update(OrderModel obj)
        {
            bool Isupdated = false;
            obj.Costumerorder.Modifiedtime = DateTime.Now;
            unitOfWork.SPCostumerorderRepository.update(unitOfWork.SPCostumerorderRepository.Getbyid(obj.Costumerorder.Id), obj.Costumerorder);
            foreach (var item in obj.Joborder)
            {
                SPJoborder itembase = unitOfWork.SPJoborderRepository.Getbyid(item.Id);
                if (itembase != null)
                {
                    item.Modifiedtime = DateTime.Now;
                    unitOfWork.SPJoborderRepository.update(itembase, item);
                }
                else
                {
                    item.Costumerorder = obj.Costumerorder.Guid;
                    item.Createdtime = DateTime.Now;
                    unitOfWork.SPJoborderRepository.Add(item);
                }
            }
            if (unitOfWork.Complate() > 0)
            {
                Isupdated = true;
            }
            return Isupdated;
            //if (Isupdated)
            //{
            //    foreach (var item in model.Joborder)
            //    {
            //        double miktar = 0;
            //        if (oldmodel.Joborder.Find(u => u.Ürün == item.Ürün) != null)
            //        {
            //            if (model.Costumerorder.Satışyöntemi==BaseDAO.Satış)                        
            //                miktar = oldmodel.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar) - model.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar);
            //            else
            //                miktar = model.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar)-oldmodel.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar);
            //        }                       
            //        else
            //        {
            //            if (model.Costumerorder.Satışyöntemi == BaseDAO.Satınalma)
            //            {
            //                miktar = model.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar);
            //            }
            //            else
            //            {
            //                miktar =-1*model.Joborder.Where(u => u.Ürün == item.Ürün).Sum(u => u.Miktar);
            //            }
            //        }

            //        //int değişimmiktarı = item.Miktar - oldmodel.Joborder.Find()
            //        StokModel stokmodel = dao.Getselectedstok(item.Ürün);                   
            //        stokmodel.Miktar += miktar;                  
            //        dao.GenericUpdate(stokmodel);
            //    }
            //}            
        }
        [Route("GetSource")]
        [HttpGet]
        public helperclass GetSource()
        {
            helperclass helperclass = new helperclass
            {
                Definedcompany = unitOfWork.SPDefinescompanyRepository.GetAll(),
                Definedcostumer = unitOfWork.SPDefinedcostumerRepository.GetAll(),
                Unit = unitOfWork.GLUnitRepository.GetAll(),
                Processcase = unitOfWork.GLCaseRespository.GetAll(),
                Tax = unitOfWork.GLTaxRepository.GetAll(),
                Producttype = unitOfWork.GLProducttypeRepository.GetAll(),
                Processtype = unitOfWork.GLProcesstypeRepository.GetAll(),
                Salesman = unitOfWork.GLSalesmanRepository.GetAll(),
                Costumertype = unitOfWork.GLCostumertypeRepository.GetAll(),
                Salestype = unitOfWork.GLSalestypeRepository.GetAll(),
                Paymenttype = unitOfWork.GLPaymenttypeRepository.GetAll(),
                Stockproduct = unitOfWork.GLStockRepository.GetAll(),
                Adisyonmenu = unitOfWork.ADMenusRepository.GetAll(),
                Roles = unitOfWork.GLRolesRepository.GetAll()
            };
            return helperclass;
        }
        [Route("Getselectedmodel")]
        [HttpGet]
        public OrderModel Getselectedmodel(int ID)
        {
            OrderModel model = new OrderModel();
            model.Costumerorder = unitOfWork.SPCostumerorderRepository.Getbyid(ID);
            model.Joborder = unitOfWork.SPJoborderRepository.GetByIDJobOrders(model.Costumerorder.Guid);
            return model;
        }
        [Route("Getjoborderlist")]
        [HttpGet]
        public List<string> Getjoborderlist()
        {
            List<string> list = new List<string>();
            list = unitOfWork.SPJoborderRepository.GetAll().Select(u => u.Joborderno).ToList();
            return list;
        }

        [Route("Getselectedstok")]
        [HttpGet]
        public GLStock Getselectedstok(string name)
        {
            GLStock response = new GLStock();
            response = unitOfWork.GLStockRepository.getstockbyguid(name);
            return response;
        }

        [Route("Getnewid")]
        [HttpGet]
        public int Getnewid()
        {
            int id = 0;
            id = unitOfWork.SPCostumerorderRepository.GetMaxId();
            return id;
        }

        [Route("Getselectedfilelist")]
        [HttpGet]
        public List<SPFilemanagement> Getselectedfilelist(int id)
        {
            List<SPFilemanagement> list = new List<SPFilemanagement>();
            list = unitOfWork.SPFilemanagementRepository.Getidbyfiles(id);
            return list;
        }
        [Route("Delete")]
        [HttpPost]
        public bool Delete(OrderModel obj)
        {
            bool Isupdated = false;
            obj.Costumerorder.Deletetime = DateTime.Now;
            obj.Costumerorder.Isactive = false;
            unitOfWork.SPCostumerorderRepository.update(unitOfWork.SPCostumerorderRepository.Getbyid(obj.Costumerorder.Id), obj.Costumerorder);
            foreach (var item in obj.Joborder)
            {
                item.Deletetime = DateTime.Now;
                item.Isactive = false;
                unitOfWork.SPJoborderRepository.update(unitOfWork.SPJoborderRepository.Getbyid(item.Id), item);
            }
            return Isupdated;
        }
    }
    public class helperclass
    {
        public List<SPDefinedcompany> Definedcompany { get; set; }
        public List<SPDefinedcostumer> Definedcostumer { get; set; }
        public List<GLProducttype> Producttype { get; set; }
        public List<GLProcesstype> Processtype { get; set; }
        public List<GLPaymenttype> Paymenttype { get; set; }
        public List<GLCase> Processcase { get; set; }
        public List<GLUnit> Unit { get; set; }
        public List<GLTax> Tax { get; set; }
        public List<GLStock> Stockproduct { get; set; }
        public List<GLSalesman> Salesman { get; set; }
        public List<GLCostumertype> Costumertype { get; set; }
        public List<GLRoles> Roles { get; set; }
        public List<GLSalestype> Salestype { get; set; }
        public List<ADMenus> Adisyonmenu { get; set; }
    }

}
