using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisSalesmanController : ControllerBase
    {
        //UnitOfWork unitOfWork = new UnitOfWork(new Starnoteapicontext());
        //Starnoteapicontext context = new Starnoteapicontext();
        //public static string Satınalma = "SATIN ALMA";
        //public static string Satış = "SATIŞ";
        //[HttpGet]
        //public List<SalesmanAnalysisModel> GetSalesmanlistsales(string ay)
        //{
        //    List<SalesmanAnalysisModel> salesmansales = new List<SalesmanAnalysisModel>();
        //    List<string> salesmans = new List<string>();
        //    try
        //    {
        //        salesmans = objcontext.tbl_salesman.Select(u => u.Value).ToList();
        //        string salestype = Satış;
        //        DateTime filterdate = Convert.ToDateTime(ay);
        //        string month = filterdate.Month.ToString("D2");
        //        string year = filterdate.Year.ToString();
        //        objcontext = new StarNoteEntity();
        //        foreach (var salesman in salesmans)
        //        {
        //            var enttiyresult = context.Database.SqlQuery<partial_salesman>("Select tbl_customerorder.ID, tbl_joborder.Product AS PRODUCT, tbl_joborder.Amounttype AS PCSTYPE, tbl_joborder.Amount AS PCS, SUM(tbl_joborder.Price * 1) AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID = tbl_joborder.Upperid WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "' AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_customerorder.Salesman = '" + salesman + "'  AND tbl_customerorder.Salesmethod = '" + Satış + "' GROUP BY tbl_joborder.Product ").ToList();
        //            int IDcounter = 1;
        //            foreach (var item in enttiyresult)
        //            {
        //                SalesmanAnalysisModel salesmanAnalysisModel = new SalesmanAnalysisModel();
        //                salesmanAnalysisModel.Id = IDcounter;
        //                salesmanAnalysisModel.Görevli = salesman;
        //                salesmanAnalysisModel.Ürün = item.PRODUCT;
        //                salesmanAnalysisModel.Birim = item.PCSTYPE;
        //                salesmanAnalysisModel.Adet = Convert.ToInt32(item.PCS);
        //                salesmanAnalysisModel.Ücret = Convert.ToDouble(item.PRICE);
        //                salesmansales.Add(salesmanAnalysisModel);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return salesmansales;
        //}

        //[HttpGet]
        //public List<SalesmanAnalysisModel> GetSalesmanlistpurchase(string ay)
        //{
        //    List<SalesmanAnalysisModel> Salesmanpurchase = new List<SalesmanAnalysisModel>();
        //    Salesmanpurchase = new List<SalesmanAnalysisModel>(dao.Fillsalesmantablepurchase(ay));
        //    return Salesmanpurchase;
        //}

        //[HttpGet]
        //public List<DataPoint> GetPurchasePie(string date)
        //{
        //    List<DataPoint> Purchasepie = new List<DataPoint>();
        //    Purchasepie = dao.loadpurchasepiessalesman(date);
        //    return Purchasepie;
        //}
        //[HttpGet]
        //public List<DataPoint> GetSalesPie(string date)
        //{
        //    List<DataPoint> Salespie = new List<DataPoint>();
        //    Salespie = dao.Loadsalespiessalesman(date);
        //    return Salespie;
        //}

        public partial class partial_salesman
        {
            public int ID { get; set; }
            public string PRODUCT { get; set; }
            public string PCSTYPE { get; set; }
            public string PCS { get; set; }
            public string PRICE { get; set; }
        }
    }

}
