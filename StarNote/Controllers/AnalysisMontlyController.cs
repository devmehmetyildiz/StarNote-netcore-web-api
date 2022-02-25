using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarNote.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisMontlyController : ControllerBase
    {
        //UnitOfWork unitOfWork = new UnitOfWork(new Starnoteapicontext());
        //Starnoteapicontext context = new Starnoteapicontext();
        //public static string Satınalma = "SATIN ALMA";
        //public static string Satış = "SATIŞ";

        //[HttpGet]
        //public List<AnalysisMontlyModel> GetMontlyAnalysis(string datefilter)
        //{

        //    List<AnalysisMontlyModel> analysis = new List<AnalysisMontlyModel>();
        //    List<string> stoknames = new List<string>();
        //    try
        //    {
        //        stoknames = unitOfWork.SPJoborderRepository.Getusedstocks().Distinct().ToList();
        //        DateTime filterdate = Convert.ToDateTime(datefilter);
        //        string month = filterdate.Month.ToString("D2");
        //        string year = filterdate.Year.ToString();
        //        int IDcounter = 1;
        //        AnalysisMontlyModel analysisMontlyModel;
        //        var enttiyresult1 = context.Database.SqlQuery<partial_analysis>("Select tbl_customerorder.ID,tbl_customerorder.Daliverydate AS RAN_DATE,(SUM(Case When tbl_customerorder.Salesmethod = '" + Satış + "' Then tbl_joborder.Price ELSE 0 END) - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.Price ELSE 0 END)) AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID=tbl_joborder.Upperid WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_customerorder.savetype = '1' GROUP BY tbl_customerorder.Daliverydate ").ToList();
        //        analysisMontlyModel = new AnalysisMontlyModel();
        //        analysisMontlyModel.Id = IDcounter;
        //        analysisMontlyModel.Urun = "GENEL HARCAMALAR";
        //        foreach (var item in enttiyresult1)
        //        {
        //            string date = item.RAN_DATE.Substring(0, 2);
        //            switch (date)
        //            {
        //                case "01":
        //                    analysisMontlyModel.Gun1 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "02":
        //                    analysisMontlyModel.Gun2 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "03":
        //                    analysisMontlyModel.Gun3 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "04":
        //                    analysisMontlyModel.Gun4 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "05":
        //                    analysisMontlyModel.Gun5 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "06":
        //                    analysisMontlyModel.Gun6 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "07":
        //                    analysisMontlyModel.Gun7 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "08":
        //                    analysisMontlyModel.Gun8 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "09":
        //                    analysisMontlyModel.Gun9 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "10":
        //                    analysisMontlyModel.Gun10 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "11":
        //                    analysisMontlyModel.Gun11 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "12":
        //                    analysisMontlyModel.Gun12 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "13":
        //                    analysisMontlyModel.Gun13 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "14":
        //                    analysisMontlyModel.Gun14 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "15":
        //                    analysisMontlyModel.Gun15 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "16":
        //                    analysisMontlyModel.Gun16 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "17":
        //                    analysisMontlyModel.Gun17 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "18":
        //                    analysisMontlyModel.Gun18 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "19":
        //                    analysisMontlyModel.Gun19 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "20":
        //                    analysisMontlyModel.Gun20 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "21":
        //                    analysisMontlyModel.Gun21 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "22":
        //                    analysisMontlyModel.Gun22 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "23":
        //                    analysisMontlyModel.Gun23 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "24":
        //                    analysisMontlyModel.Gun24 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "25":
        //                    analysisMontlyModel.Gun25 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "26":
        //                    analysisMontlyModel.Gun26 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "27":
        //                    analysisMontlyModel.Gun27 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "28":
        //                    analysisMontlyModel.Gun28 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "29":
        //                    analysisMontlyModel.Gun29 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "30":
        //                    analysisMontlyModel.Gun30 = Convert.ToDouble(item.PRICE);
        //                    break;
        //                case "31":
        //                    analysisMontlyModel.Gun31 = Convert.ToDouble(item.PRICE);
        //                    break;

        //            }
        //        }
        //        analysis.Add(analysisMontlyModel);
        //        IDcounter++;
        //        foreach (var stokname in stoknames)
        //        {
        //            var enttiyresult = context.Database.SqlQuery<partial_analysis>("Select tbl_customerorder.ID,tbl_customerorder.Daliverydate AS RAN_DATE,(SUM(Case When tbl_customerorder.Salesmethod = '" + Satış + "' Then tbl_joborder.Price ELSE 0 END) - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.Price ELSE 0 END)) AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID=tbl_joborder.Upperid WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_joborder.Product='" + stokname + "' GROUP BY tbl_customerorder.Daliverydate ").ToList();
        //            analysisMontlyModel = new AnalysisMontlyModel();
        //            analysisMontlyModel.Id = IDcounter;
        //            analysisMontlyModel.Urun = stokname;
        //            foreach (var item in enttiyresult)
        //            {
        //                string date = item.RAN_DATE.Substring(0, 2);
        //                switch (date)
        //                {
        //                    case "01":
        //                        analysisMontlyModel.Gun1 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "02":
        //                        analysisMontlyModel.Gun2 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "03":
        //                        analysisMontlyModel.Gun3 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "04":
        //                        analysisMontlyModel.Gun4 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "05":
        //                        analysisMontlyModel.Gun5 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "06":
        //                        analysisMontlyModel.Gun6 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "07":
        //                        analysisMontlyModel.Gun7 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "08":
        //                        analysisMontlyModel.Gun8 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "09":
        //                        analysisMontlyModel.Gun9 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "10":
        //                        analysisMontlyModel.Gun10 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "11":
        //                        analysisMontlyModel.Gun11 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "12":
        //                        analysisMontlyModel.Gun12 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "13":
        //                        analysisMontlyModel.Gun13 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "14":
        //                        analysisMontlyModel.Gun14 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "15":
        //                        analysisMontlyModel.Gun15 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "16":
        //                        analysisMontlyModel.Gun16 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "17":
        //                        analysisMontlyModel.Gun17 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "18":
        //                        analysisMontlyModel.Gun18 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "19":
        //                        analysisMontlyModel.Gun19 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "20":
        //                        analysisMontlyModel.Gun20 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "21":
        //                        analysisMontlyModel.Gun21 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "22":
        //                        analysisMontlyModel.Gun22 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "23":
        //                        analysisMontlyModel.Gun23 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "24":
        //                        analysisMontlyModel.Gun24 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "25":
        //                        analysisMontlyModel.Gun25 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "26":
        //                        analysisMontlyModel.Gun26 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "27":
        //                        analysisMontlyModel.Gun27 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "28":
        //                        analysisMontlyModel.Gun28 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "29":
        //                        analysisMontlyModel.Gun29 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "30":
        //                        analysisMontlyModel.Gun30 = Convert.ToDouble(item.PRICE);
        //                        break;
        //                    case "31":
        //                        analysisMontlyModel.Gun31 = Convert.ToDouble(item.PRICE);
        //                        break;

        //                }
        //            }
        //            analysis.Add(analysisMontlyModel);
        //            IDcounter++;
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return analysis;
        //}

        //[HttpGet]
        //public List<string> Getmontlysalesgauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    try
        //    {
        //        DateTime filterdate = Convert.ToDateTime(date);
        //        string month = filterdate.Month.ToString("D2");
        //        string year = filterdate.Year.ToString();
        //        string item = unitOfWork.SPCostumerorderRepository.Getmontlygauge(month, year, Satış);
        //        if (item == string.Empty)
        //            item = "0";
        //        output.Add(item);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return output;
        //}

        //[HttpGet]
        //public List<string> Getmontlypurchasegauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    try
        //    {
        //        DateTime filterdate = Convert.ToDateTime(date);
        //        string month = filterdate.Month.ToString("D2");
        //        string year = filterdate.Year.ToString();
        //        string item = unitOfWork.SPCostumerorderRepository.Getmontlygauge(month, year, Satınalma);
        //        output.Add(item);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return output;
        //}

        //[HttpGet]
        //public List<string> Getmontlynetgauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    try
        //    {
        //        DateTime filterdate = Convert.ToDateTime(date);
        //        string month = filterdate.Month.ToString("D2");
        //        string year = filterdate.Year.ToString();
        //        string outcome = unitOfWork.SPCostumerorderRepository.Getmontlygauge(month, year, Satınalma);
        //        string income = unitOfWork.SPCostumerorderRepository.Getmontlygauge(month, year, Satış);
        //        if (outcome.Trim() == string.Empty)
        //            outcome = "0";
        //        if (income.Trim() == string.Empty)
        //            income = "0";
        //        double netdeger = Convert.ToDouble(income) - Convert.ToDouble(outcome);
        //        output.Add(netdeger.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return output;
        //}

        //public partial class partial_analysis
        //{
        //    public int ID { get; set; }
        //    public string RAN_DATE { get; set; }
        //    public string PRICE { get; set; }
        //}
    }
}
