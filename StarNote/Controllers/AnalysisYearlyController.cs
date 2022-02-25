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
    public class AnalysisYearlyController : ControllerBase
    {
        //AnalysisDAO db1dataaccess = new AnalysisDAO();
        //IDAO dao;
        //AnalysisYearlyController()
        //{
        //    dao = DAOBase.GetDAO();
        //}
        //[HttpGet]
        //public List<AnalysisYearlyModel> GetYearlyAnalysis(string date)
        //{
        //    List<AnalysisYearlyModel> Yearlylist = new List<AnalysisYearlyModel>();
        //    Yearlylist = dao.Fillyearlyanalysis(date);
        //    return Yearlylist;
        //}


        //[HttpGet]
        //public List<string> Getyearlysalesgauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    output = new List<string>(dao.yearlyanalysissalesgaugefill(date));
        //    return output;
        //}

        //[HttpGet]
        //public List<string> Getyearlypurchasegauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    output = new List<string>(dao.yearlyanalysispurchasegaugefill(date));
        //    return output;
        //}

        //[HttpGet]
        //public List<string> Getyearlynetgauge(string date)
        //{
        //    List<string> output = new List<string>();
        //    output = new List<string>(dao.yearlyanalysisnetgaugefill(date));
        //    return output;
        //}
    }
}
