using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarNote.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarNote.Models.UIModels;
using Microsoft.Extensions.Logging;

namespace StarNote.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisController : ControllerBase
    {
        private readonly ILogger<AdisyonmenusController> _logger;
        private readonly Starnoteapicontext _context;
        UnitOfWork unitOfWork;

        private string genelaylık = "11";
        private string genelyıllık = "12";
        private string adliyeaylık = "101";
        private string adliyeyıllık = "201";
        private string özelaylık = "102";
        private string özelyıllık = "202";
        private string digerkurumaylık = "103";
        private string digerkurumyıllık = "203";
        private string harcamaaylık = "104";
        private string harcamayıllık = "204";
        private string ekgeliraylık = "105";
        private string ekgeliryıllık = "205";
        public AnalysisController(ILogger<AdisyonmenusController> logger, Starnoteapicontext context)
        {
            _logger = logger;
            _context = context;
            unitOfWork = new UnitOfWork(context);
        }
        public List<AnalysisMontlyModel> Fillmontlyanalysis(string datefilter, string type)
        {
            List<AnalysisMontlyModel> analysis = new List<AnalysisMontlyModel>();
            List<string> stoknamesall = new List<string>();
            List<string> stoknames = new List<string>();
            DateTime filterdate = Convert.ToDateTime(datefilter);
            string month = filterdate.Month.ToString("D2");
            string year = filterdate.Year.ToString();
            stoknamesall = unitOfWork.SPJoborderRepository.Getusedproducts();
            foreach (var item in stoknamesall)
            {
                if (type == harcamaaylık || type == ekgeliraylık)
                {
                    if (objcontext.tbl_stok.SingleOrDefault(u => u.Name == item) == null)
                        stoknames.Add(item);
                }
                else
                {
                    if (objcontext.tbl_stok.SingleOrDefault(u => u.Name == item) != null)
                        stoknames.Add(item);
                }
            }
            try
            {
                int IDcounter = 1;
                AnalysisMontlyModel analysisMontlyModel;
                if (type == genelaylık)
                {
                    objcontext = new StarNoteEntity();
                    string sql = "";
                    sql += " Select tbl_customerorder.ID";
                    sql += " ,tbl_customerorder.Daliverydate AS RAN_DATE";
                    sql += " ,(SUM(Case When tbl_customerorder.Salesmethod = '" + Satış + "' Then tbl_joborder.Price ELSE 0 END)";
                    sql += " - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.Price ELSE 0 END)) AS PRICE";
                    sql += "  from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID=tbl_joborder.Upperid";
                    sql += " WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND";
                    sql += " tbl_customerorder.savetype = '1' GROUP BY tbl_customerorder.Daliverydate";
                    var enttiyresult1 = objcontext.partial_analysis.SqlQuery(sql).ToList();
                    analysisMontlyModel = new AnalysisMontlyModel();
                    analysisMontlyModel.Id = IDcounter;
                    analysisMontlyModel.Urun = "GENEL HARCAMALAR";
                    foreach (var item in enttiyresult1)
                    {
                        string date = item.RAN_DATE.Substring(0, 2);
                        switch (date)
                        {
                            case "01":
                                analysisMontlyModel.Gun1 = Convert.ToDouble(item.PRICE);
                                break;
                            case "02":
                                analysisMontlyModel.Gun2 = Convert.ToDouble(item.PRICE);
                                break;
                            case "03":
                                analysisMontlyModel.Gun3 = Convert.ToDouble(item.PRICE);
                                break;
                            case "04":
                                analysisMontlyModel.Gun4 = Convert.ToDouble(item.PRICE);
                                break;
                            case "05":
                                analysisMontlyModel.Gun5 = Convert.ToDouble(item.PRICE);
                                break;
                            case "06":
                                analysisMontlyModel.Gun6 = Convert.ToDouble(item.PRICE);
                                break;
                            case "07":
                                analysisMontlyModel.Gun7 = Convert.ToDouble(item.PRICE);
                                break;
                            case "08":
                                analysisMontlyModel.Gun8 = Convert.ToDouble(item.PRICE);
                                break;
                            case "09":
                                analysisMontlyModel.Gun9 = Convert.ToDouble(item.PRICE);
                                break;
                            case "10":
                                analysisMontlyModel.Gun10 = Convert.ToDouble(item.PRICE);
                                break;
                            case "11":
                                analysisMontlyModel.Gun11 = Convert.ToDouble(item.PRICE);
                                break;
                            case "12":
                                analysisMontlyModel.Gun12 = Convert.ToDouble(item.PRICE);
                                break;
                            case "13":
                                analysisMontlyModel.Gun13 = Convert.ToDouble(item.PRICE);
                                break;
                            case "14":
                                analysisMontlyModel.Gun14 = Convert.ToDouble(item.PRICE);
                                break;
                            case "15":
                                analysisMontlyModel.Gun15 = Convert.ToDouble(item.PRICE);
                                break;
                            case "16":
                                analysisMontlyModel.Gun16 = Convert.ToDouble(item.PRICE);
                                break;
                            case "17":
                                analysisMontlyModel.Gun17 = Convert.ToDouble(item.PRICE);
                                break;
                            case "18":
                                analysisMontlyModel.Gun18 = Convert.ToDouble(item.PRICE);
                                break;
                            case "19":
                                analysisMontlyModel.Gun19 = Convert.ToDouble(item.PRICE);
                                break;
                            case "20":
                                analysisMontlyModel.Gun20 = Convert.ToDouble(item.PRICE);
                                break;
                            case "21":
                                analysisMontlyModel.Gun21 = Convert.ToDouble(item.PRICE);
                                break;
                            case "22":
                                analysisMontlyModel.Gun22 = Convert.ToDouble(item.PRICE);
                                break;
                            case "23":
                                analysisMontlyModel.Gun23 = Convert.ToDouble(item.PRICE);
                                break;
                            case "24":
                                analysisMontlyModel.Gun24 = Convert.ToDouble(item.PRICE);
                                break;
                            case "25":
                                analysisMontlyModel.Gun25 = Convert.ToDouble(item.PRICE);
                                break;
                            case "26":
                                analysisMontlyModel.Gun26 = Convert.ToDouble(item.PRICE);
                                break;
                            case "27":
                                analysisMontlyModel.Gun27 = Convert.ToDouble(item.PRICE);
                                break;
                            case "28":
                                analysisMontlyModel.Gun28 = Convert.ToDouble(item.PRICE);
                                break;
                            case "29":
                                analysisMontlyModel.Gun29 = Convert.ToDouble(item.PRICE);
                                break;
                            case "30":
                                analysisMontlyModel.Gun30 = Convert.ToDouble(item.PRICE);
                                break;
                            case "31":
                                analysisMontlyModel.Gun31 = Convert.ToDouble(item.PRICE);
                                break;

                        }
                    }
                    analysis.Add(analysisMontlyModel);
                    IDcounter++;
                }
                foreach (var stokname in stoknames)
                {
                    objcontext = new StarNoteEntity();
                    string sqlcmd = "";
                    sqlcmd += "Select tbl_customerorder.ID,tbl_customerorder.Daliverydate AS RAN_DATE,";
                    sqlcmd += " (SUM(Case When tbl_customerorder.Salesmethod = '" + Satış + "' Then tbl_joborder.Price ELSE 0 END)";
                    sqlcmd += " - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.Price ELSE 0 END)) AS";
                    sqlcmd += " PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID=tbl_joborder.Upperid";
                    sqlcmd += " WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND";
                    sqlcmd += " tbl_joborder.Product2='" + stokname + "' ";
                    if (type == adliyeaylık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type <>'ÖZEL MÜŞTERİLER'";
                        sqlcmd += " AND tbl_customerorder.Type <>'ŞİRKETLER'";
                    }
                    if (type == özelaylık)
                    {
                        sqlcmd += "AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type ='ÖZEL MÜŞTERİLER'";
                    }
                    if (type == digerkurumaylık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type ='ŞİRKETLER'";
                    }
                    if (type == harcamaaylık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='1'";
                        sqlcmd += " AND tbl_customerorder.Salesmethod = 'GIDER'";
                    }
                    if (type == ekgeliraylık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='1'";
                        sqlcmd += " AND tbl_customerorder.Salesmethod = 'GELIR'";
                    }
                    sqlcmd += " GROUP BY tbl_customerorder.Daliverydate";
                    var enttiyresult = objcontext.partial_analysis.SqlQuery(sqlcmd).ToList();
                    analysisMontlyModel = new AnalysisMontlyModel();
                    analysisMontlyModel.Id = IDcounter;
                    analysisMontlyModel.Urun = stokname;
                    foreach (var item in enttiyresult)
                    {
                        string date = item.RAN_DATE.Substring(0, 2);
                        switch (date)
                        {
                            case "01":
                                analysisMontlyModel.Gun1 += Convert.ToDouble(item.PRICE);
                                break;
                            case "02":
                                analysisMontlyModel.Gun2 += Convert.ToDouble(item.PRICE);
                                break;
                            case "03":
                                analysisMontlyModel.Gun3 += Convert.ToDouble(item.PRICE);
                                break;
                            case "04":
                                analysisMontlyModel.Gun4 += Convert.ToDouble(item.PRICE);
                                break;
                            case "05":
                                analysisMontlyModel.Gun5 += Convert.ToDouble(item.PRICE);
                                break;
                            case "06":
                                analysisMontlyModel.Gun6 += Convert.ToDouble(item.PRICE);
                                break;
                            case "07":
                                analysisMontlyModel.Gun7 += Convert.ToDouble(item.PRICE);
                                break;
                            case "08":
                                analysisMontlyModel.Gun8 += Convert.ToDouble(item.PRICE);
                                break;
                            case "09":
                                analysisMontlyModel.Gun9 += Convert.ToDouble(item.PRICE);
                                break;
                            case "10":
                                analysisMontlyModel.Gun10 += Convert.ToDouble(item.PRICE);
                                break;
                            case "11":
                                analysisMontlyModel.Gun11 += Convert.ToDouble(item.PRICE);
                                break;
                            case "12":
                                analysisMontlyModel.Gun12 += Convert.ToDouble(item.PRICE);
                                break;
                            case "13":
                                analysisMontlyModel.Gun13 += Convert.ToDouble(item.PRICE);
                                break;
                            case "14":
                                analysisMontlyModel.Gun14 += Convert.ToDouble(item.PRICE);
                                break;
                            case "15":
                                analysisMontlyModel.Gun15 += Convert.ToDouble(item.PRICE);
                                break;
                            case "16":
                                analysisMontlyModel.Gun16 += Convert.ToDouble(item.PRICE);
                                break;
                            case "17":
                                analysisMontlyModel.Gun17 += Convert.ToDouble(item.PRICE);
                                break;
                            case "18":
                                analysisMontlyModel.Gun18 += Convert.ToDouble(item.PRICE);
                                break;
                            case "19":
                                analysisMontlyModel.Gun19 += Convert.ToDouble(item.PRICE);
                                break;
                            case "20":
                                analysisMontlyModel.Gun20 += Convert.ToDouble(item.PRICE);
                                break;
                            case "21":
                                analysisMontlyModel.Gun21 += Convert.ToDouble(item.PRICE);
                                break;
                            case "22":
                                analysisMontlyModel.Gun22 += Convert.ToDouble(item.PRICE);
                                break;
                            case "23":
                                analysisMontlyModel.Gun23 += Convert.ToDouble(item.PRICE);
                                break;
                            case "24":
                                analysisMontlyModel.Gun24 += Convert.ToDouble(item.PRICE);
                                break;
                            case "25":
                                analysisMontlyModel.Gun25 += Convert.ToDouble(item.PRICE);
                                break;
                            case "26":
                                analysisMontlyModel.Gun26 += Convert.ToDouble(item.PRICE);
                                break;
                            case "27":
                                analysisMontlyModel.Gun27 += Convert.ToDouble(item.PRICE);
                                break;
                            case "28":
                                analysisMontlyModel.Gun28 += Convert.ToDouble(item.PRICE);
                                break;
                            case "29":
                                analysisMontlyModel.Gun29 += Convert.ToDouble(item.PRICE);
                                break;
                            case "30":
                                analysisMontlyModel.Gun30 += Convert.ToDouble(item.PRICE);
                                break;
                            case "31":
                                analysisMontlyModel.Gun31 += Convert.ToDouble(item.PRICE);
                                break;

                        }
                    }
                    analysis.Add(analysisMontlyModel);
                    IDcounter++;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return analysis;
        }

        public List<AnalysisYearlyModel> Fillyearlyanalysis(string datefilter, string type)
        {
            List<AnalysisYearlyModel> analysis = new List<AnalysisYearlyModel>();
            List<string> stoknamesall = new List<string>();
            List<string> stoknames = new List<string>();
            DateTime filterdate = Convert.ToDateTime(datefilter);
            string month = filterdate.Month.ToString("D2");
            string year = filterdate.Year.ToString();
            AnalysisYearlyModel analysisYearlyModel;
            try
            {
                stoknamesall = objcontext.tbl_joborder.Select(u => u.Product2).Distinct().ToList();
                foreach (var item in stoknamesall)
                {
                    if (type == harcamaaylık || type == ekgeliraylık)
                    {
                        if (objcontext.tbl_stok.SingleOrDefault(u => u.Name == item) == null)
                            stoknames.Add(item);
                    }
                    else
                    {
                        if (objcontext.tbl_stok.SingleOrDefault(u => u.Name == item) != null)
                            stoknames.Add(item);
                    }
                }
                //stoknames = objcontext.tbl_stok.Select(u => u.Name).Distinct().ToList();               
                int IDcounter = 1;
                if (type == genelyıllık)
                {
                    objcontext = new StarNoteEntity();
                    string sql = "Select tbl_customerorder.ID AS ID, tbl_customerorder.Daliverydate AS RAN_DATE, (SUM(Case When tbl_customerorder.Salesmethod = '" + Satış + "' Then";
                    sql += " tbl_joborder.PRICE ELSE 0 END) - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.PRICE ELSE 0 END))";
                    sql += " AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID = tbl_joborder.Upperid";
                    sql += " WHERE MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_customerorder.savetype = '1' GROUP BY MID(tbl_customerorder.Daliverydate, 4, 2)";
                    var enttiyresult1 = objcontext.partial_analysis.SqlQuery(sql).ToList();
                    analysisYearlyModel = new AnalysisYearlyModel();
                    analysisYearlyModel.Id = IDcounter;
                    analysisYearlyModel.Urun = "GENEL HARCAMALAR";
                    foreach (var item in enttiyresult1)
                    {
                        string date = item.RAN_DATE.Substring(3, 2);
                        switch (date)
                        {
                            case "01":
                                analysisYearlyModel.Ay1 = Convert.ToDouble(item.PRICE);
                                break;
                            case "02":
                                analysisYearlyModel.Ay2 = Convert.ToDouble(item.PRICE);
                                break;
                            case "03":
                                analysisYearlyModel.Ay3 = Convert.ToDouble(item.PRICE);
                                break;
                            case "04":
                                analysisYearlyModel.Ay4 = Convert.ToDouble(item.PRICE);
                                break;
                            case "05":
                                analysisYearlyModel.Ay5 = Convert.ToDouble(item.PRICE);
                                break;
                            case "06":
                                analysisYearlyModel.Ay6 = Convert.ToDouble(item.PRICE);
                                break;
                            case "07":
                                analysisYearlyModel.Ay7 = Convert.ToDouble(item.PRICE);
                                break;
                            case "08":
                                analysisYearlyModel.Ay8 = Convert.ToDouble(item.PRICE);
                                break;
                            case "09":
                                analysisYearlyModel.Ay9 = Convert.ToDouble(item.PRICE);
                                break;
                            case "10":
                                analysisYearlyModel.Ay10 = Convert.ToDouble(item.PRICE);
                                break;
                            case "11":
                                analysisYearlyModel.Ay11 = Convert.ToDouble(item.PRICE);
                                break;
                            case "12":
                                analysisYearlyModel.Ay12 = Convert.ToDouble(item.PRICE);
                                break;
                        }
                    }
                    analysis.Add(analysisYearlyModel);
                    IDcounter++;
                }

                foreach (var stokname in stoknames)
                {
                    objcontext = new StarNoteEntity();
                    string sqlcmd = "Select tbl_customerorder.ID AS ID, tbl_customerorder.Daliverydate AS RAN_DATE, (SUM(Case";
                    sqlcmd += " When tbl_customerorder.Salesmethod = '" + Satış + "' Then tbl_joborder.PRICE ELSE 0 END)";
                    sqlcmd += " - SUM(Case When tbl_customerorder.Salesmethod = '" + Satınalma + "' Then tbl_joborder.PRICE ELSE 0 END))";
                    sqlcmd += " AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID = tbl_joborder.Upperid WHERE";
                    sqlcmd += " MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_joborder.Product2 = '" + stokname + "' AND tbl_customerorder.savetype = '0'";
                    if (type == adliyeyıllık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type <>'ÖZEL MÜŞTERİLER'";
                        sqlcmd += " AND tbl_customerorder.Type <>'ŞİRKETLER'";
                    }
                    if (type == özelyıllık)
                    {
                        sqlcmd += "AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type ='ÖZEL MÜŞTERİLER'";
                    }
                    if (type == digerkurumyıllık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='0'";
                        sqlcmd += " AND tbl_customerorder.Type ='ŞİRKETLER'";
                    }
                    if (type == harcamayıllık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='1'";
                        sqlcmd += " AND tbl_customerorder.Salesmethod = 'GIDER'";
                    }
                    if (type == ekgeliryıllık)
                    {
                        sqlcmd += " AND tbl_customerorder.savetype='1'";
                        sqlcmd += " AND tbl_customerorder.Salesmethod = 'GELIR'";
                    }
                    sqlcmd += " GROUP BY MID(tbl_customerorder.Daliverydate, 4, 2)";
                    var enttiyresult = objcontext.partial_analysis.SqlQuery(sqlcmd).ToList();
                    analysisYearlyModel = new AnalysisYearlyModel();
                    analysisYearlyModel.Id = IDcounter;
                    analysisYearlyModel.Urun = stokname;
                    foreach (var item in enttiyresult)
                    {
                        string date = item.RAN_DATE.Substring(3, 2);
                        switch (date)
                        {
                            case "01":
                                analysisYearlyModel.Ay1 += Convert.ToDouble(item.PRICE);
                                break;
                            case "02":
                                analysisYearlyModel.Ay2 += Convert.ToDouble(item.PRICE);
                                break;
                            case "03":
                                analysisYearlyModel.Ay3 += Convert.ToDouble(item.PRICE);
                                break;
                            case "04":
                                analysisYearlyModel.Ay4 += Convert.ToDouble(item.PRICE);
                                break;
                            case "05":
                                analysisYearlyModel.Ay5 += Convert.ToDouble(item.PRICE);
                                break;
                            case "06":
                                analysisYearlyModel.Ay6 += Convert.ToDouble(item.PRICE);
                                break;
                            case "07":
                                analysisYearlyModel.Ay7 += Convert.ToDouble(item.PRICE);
                                break;
                            case "08":
                                analysisYearlyModel.Ay8 += Convert.ToDouble(item.PRICE);
                                break;
                            case "09":
                                analysisYearlyModel.Ay9 += Convert.ToDouble(item.PRICE);
                                break;
                            case "10":
                                analysisYearlyModel.Ay10 += Convert.ToDouble(item.PRICE);
                                break;
                            case "11":
                                analysisYearlyModel.Ay11 += Convert.ToDouble(item.PRICE);
                                break;
                            case "12":
                                analysisYearlyModel.Ay12 += Convert.ToDouble(item.PRICE);
                                break;
                        }
                    }
                    analysis.Add(analysisYearlyModel);
                    IDcounter++;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return analysis;
        }

        public List<string> monthanalysispotansialgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year) select c.Pricewaiting).Sum().ToString();
                if (type == adliyeaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Pricewaiting).Sum().ToString();
                if (type == özelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Pricewaiting).Sum().ToString();
                if (type == digerkurumaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Pricewaiting).Sum().ToString();
                if (type == harcamaaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Pricewaiting).Sum().ToString();
                if (type == ekgeliraylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Pricewaiting).Sum().ToString();
                if (item == string.Empty)
                    item = "0";
                if (item == string.Empty)
                    item = "0";
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> monthanalysissalesgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                if (type == adliyeaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == özelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                if (type == digerkurumaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == harcamaaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                if (type == ekgeliraylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                if (item == string.Empty)
                    item = "0";
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> monthanalysispurchasegaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                if (type == adliyeaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == özelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                if (type == digerkurumaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == harcamaaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                if (type == ekgeliraylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> monthanalysisnetgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string outcome = string.Empty;
                string income = string.Empty;
                if (type == genelaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                }
                if (type == adliyeaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                }
                if (type == özelaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                }
                if (type == digerkurumaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                }
                if (type == harcamaaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                }
                if (type == ekgeliraylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(3, 2) == month && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                }
                if (outcome.Trim() == string.Empty)
                    outcome = "0";
                if (income.Trim() == string.Empty)
                    income = "0";
                double netdeger = Convert.ToDouble(income) - Convert.ToDouble(outcome);

                output.Add(netdeger.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> yearlyanalysispotansialgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year) select c.Pricewaiting).Sum().ToString();
                if (type == adliyeyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Pricewaiting).Sum().ToString();
                if (type == özelyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Pricewaiting).Sum().ToString();
                if (type == digerkurumyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Pricewaiting).Sum().ToString();
                if (type == harcamayıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Pricewaiting).Sum().ToString();
                if (type == ekgeliryıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Pricewaiting).Sum().ToString();
                if (item == string.Empty)
                    item = "0";
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> yearlyanalysissalesgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                if (type == adliyeyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == özelyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                if (type == digerkurumyıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == harcamayıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                if (type == ekgeliryıllık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                if (item == string.Empty)
                    item = "0";
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> yearlyanalysispurchasegaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string item = string.Empty;
                if (type == genelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                if (type == adliyeaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == özelaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                if (type == digerkurumaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                if (type == harcamaaylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                if (type == ekgeliraylık)
                    item = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                if (item == string.Empty)
                    item = "0";
                output.Add(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<string> yearlyanalysisnetgaugefill(string datefilter, string type)
        {
            List<string> output = new List<string>();
            try
            {
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                string outcome = string.Empty;
                string income = string.Empty;
                if (type == genelaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year) select c.Price).Sum().ToString();
                }
                if (type == adliyeaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type != "ÖZEL MÜŞTERİLER" && c.Type != "ŞİRKETLER") select c.Price).Sum().ToString();
                }
                if (type == özelaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ÖZEL MÜŞTERİLER") select c.Price).Sum().ToString();
                }
                if (type == digerkurumaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Type == "ŞİRKETLER") select c.Price).Sum().ToString();
                }
                if (type == harcamaaylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GIDER") select c.Price).Sum().ToString();
                }
                if (type == ekgeliraylık)
                {
                    outcome = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satınalma && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                    income = (from c in objcontext.tbl_customerorder where (c.Salesmethod == Satış && c.Daliverydate.Substring(6, 4) == year && c.Savetype == 1 && c.Salesmethod == "GELIR") select c.Price).Sum().ToString();
                }
                if (outcome.Trim() == string.Empty)
                    outcome = "0";
                if (income.Trim() == string.Empty)
                    income = "0";
                double netdeger = Convert.ToDouble(income) - Convert.ToDouble(outcome);

                output.Add(netdeger.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return output;
        }

        public List<SalesmanAnalysisModel> Fillsalesmantablesales(string datefilter)
        {
            List<SalesmanAnalysisModel> salesmansales = new List<SalesmanAnalysisModel>();
            List<string> salesmans = new List<string>();
            try
            {
                salesmans = objcontext.tbl_salesman.Select(u => u.Value).ToList();
                string salestype = Satış;
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                objcontext = new StarNoteEntity();
                foreach (var salesman in salesmans)
                {
                    var enttiyresult = objcontext.partial_salesman.SqlQuery("Select tbl_customerorder.ID, tbl_joborder.Product AS PRODUCT, tbl_joborder.Amounttype AS PCSTYPE, tbl_joborder.Amount AS PCS, SUM(tbl_joborder.Price * 1) AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID = tbl_joborder.Upperid WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "' AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_customerorder.Salesman = '" + salesman + "'  AND tbl_customerorder.Salesmethod = '" + Satış + "' GROUP BY tbl_joborder.Product ").ToList();
                    int IDcounter = 1;
                    foreach (var item in enttiyresult)
                    {
                        SalesmanAnalysisModel salesmanAnalysisModel = new SalesmanAnalysisModel();
                        salesmanAnalysisModel.Id = IDcounter;
                        salesmanAnalysisModel.Görevli = salesman;
                        salesmanAnalysisModel.Ürün = item.PRODUCT;
                        salesmanAnalysisModel.Birim = item.PCSTYPE;
                        salesmanAnalysisModel.Adet = Convert.ToInt32(item.PCS);
                        salesmanAnalysisModel.Ücret = Convert.ToDouble(item.PRICE);
                        salesmansales.Add(salesmanAnalysisModel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesmansales;
        }

        public List<SalesmanAnalysisModel> Fillsalesmantablepurchase(string datefilter)
        {
            List<SalesmanAnalysisModel> salesmanpurchase = new List<SalesmanAnalysisModel>();
            List<string> salesmans = new List<string>();
            try
            {
                salesmans = objcontext.tbl_salesman.Select(u => u.Value).ToList();
                string salestype = Satınalma;
                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                objcontext = new StarNoteEntity();
                foreach (var salesman in salesmans)
                {
                    var enttiyresult = objcontext.partial_salesman.SqlQuery("Select tbl_customerorder.ID,tbl_joborder.Product AS PRODUCT, tbl_joborder.Amounttype AS PCSTYPE,tbl_joborder.Amount AS PCS,SUM(tbl_joborder.Price * -1) AS PRICE from tbl_customerorder LEFT JOIN tbl_joborder ON tbl_customerorder.ID = tbl_joborder.Upperid WHERE MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "' AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' AND tbl_customerorder.Salesman = '" + salesman + "'  AND tbl_customerorder.Salesmethod = '" + Satınalma + "' GROUP BY tbl_joborder.Product ").ToList();
                    int IDcounter = 1;
                    foreach (var item in enttiyresult)
                    {
                        SalesmanAnalysisModel salesmanAnalysisModel = new SalesmanAnalysisModel();
                        salesmanAnalysisModel.Id = IDcounter;
                        salesmanAnalysisModel.Görevli = salesman;
                        salesmanAnalysisModel.Ürün = item.PRODUCT;
                        salesmanAnalysisModel.Birim = item.PCSTYPE;
                        salesmanAnalysisModel.Adet = Convert.ToInt32(item.PCS);
                        salesmanAnalysisModel.Ücret = Convert.ToDouble(item.PRICE);
                        salesmanpurchase.Add(salesmanAnalysisModel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesmanpurchase;
        }

        public List<DataPoint> Loadsalespies(string datefilter)
        {
            List<DataPoint> chartsetsales = new List<DataPoint>();
            try
            {

                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                objcontext = new StarNoteEntity();
                var enttiyresult = objcontext.partial_salespie.SqlQuery("SELECT tbl_customerorder.ID,tbl_customerorder.Paymentmethod AS 'PAYMENT',COUNT(tbl_customerorder.Paymentmethod)AS COUNT FROM tbl_customerorder WHERE tbl_customerorder.Salesmethod='" + Satış + "' AND MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' GROUP BY tbl_customerorder.Paymentmethod").ToList();

                foreach (var item in enttiyresult)
                {
                    chartsetsales.Add(new DataPoint(item.PAYMENT, item.COUNT));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chartsetsales;
        }

        public List<DataPoint> loadpurchasepies(string datefilter)
        {
            List<DataPoint> chartsetpurchase = new List<DataPoint>();
            try
            {
                using (objcontext)
                {
                    DateTime filterdate = Convert.ToDateTime(datefilter);
                    string month = filterdate.Month.ToString("D2");
                    string year = filterdate.Year.ToString();
                    objcontext = new StarNoteEntity();
                    var enttiyresult = objcontext.partial_salespie.SqlQuery("SELECT tbl_customerorder.ID,tbl_customerorder.Paymentmethod AS 'PAYMENT',COUNT(tbl_customerorder.Paymentmethod)AS COUNT FROM tbl_customerorder WHERE tbl_customerorder.Salesmethod='" + Satınalma + "' AND MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' GROUP BY tbl_customerorder.Paymentmethod").ToList();
                    foreach (var item in enttiyresult)
                    {
                        chartsetpurchase.Add(new DataPoint(item.PAYMENT, item.COUNT));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chartsetpurchase;
        }

        public List<DataPoint> Loadsalespiessalesman(string datefilter)
        {
            List<DataPoint> chartsetsales = new List<DataPoint>();
            try
            {

                DateTime filterdate = Convert.ToDateTime(datefilter);
                string month = filterdate.Month.ToString("D2");
                string year = filterdate.Year.ToString();
                objcontext = new StarNoteEntity();
                var enttiyresult = objcontext.partial_salespie.SqlQuery("SELECT tbl_customerorder.ID,tbl_customerorder.Salesman AS 'PAYMENT',SUM(tbl_customerorder.Price)AS COUNT FROM tbl_customerorder WHERE tbl_customerorder.Salesmethod='" + Satış + "' AND MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' GROUP BY tbl_customerorder.Salesman").ToList();

                foreach (var item in enttiyresult)
                {
                    chartsetsales.Add(new DataPoint(item.PAYMENT, item.COUNT));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chartsetsales;
        }

        public List<DataPoint> loadpurchasepiessalesman(string datefilter)
        {
            List<DataPoint> chartsetpurchase = new List<DataPoint>();
            try
            {
                using (objcontext)
                {
                    DateTime filterdate = Convert.ToDateTime(datefilter);
                    string month = filterdate.Month.ToString("D2");
                    string year = filterdate.Year.ToString();
                    objcontext = new StarNoteEntity();
                    var enttiyresult = objcontext.partial_salespie.SqlQuery("SELECT tbl_customerorder.ID,tbl_customerorder.Salesman AS 'PAYMENT',SUM(tbl_customerorder.Price)AS COUNT FROM tbl_customerorder WHERE tbl_customerorder.Salesmethod='" + Satınalma + "' AND MID(tbl_customerorder.Daliverydate, 4, 2) = '" + month + "'AND MID(tbl_customerorder.Daliverydate, 7, 4) = '" + year + "' GROUP BY tbl_customerorder.Salesman").ToList();
                    foreach (var item in enttiyresult)
                    {
                        chartsetpurchase.Add(new DataPoint(item.PAYMENT, item.COUNT));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chartsetpurchase;
        }
    }
}
