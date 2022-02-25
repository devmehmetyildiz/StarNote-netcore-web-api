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
    public class RemindingController : ControllerBase
    {
        //IDAO dao;
        //RemindingController()
        //{
        //    dao = DAOBase.GetDAO();
        //}

        //[HttpGet]
        //public List<RemindingModel> GetAllRemindings()
        //{
        //    List<RemindingModel> list = new List<RemindingModel>();
        //    list = dao.GetAllRecords();
        //    return list;
        //}

        //[HttpGet]
        //public List<string> Filloldrecord()
        //{
        //    List<string> list = new List<string>();
        //    list = dao.Filljoborderlist();
        //    return list;
        //}

        //[HttpGet]
        //public OrderModel Getselectedrecord(int ID)
        //{
        //    OrderModel model = new OrderModel();
        //    model = dao.Getselectedrecord(ID);
        //    return model;
        //}

        //[HttpGet]
        //public List<RemindingModel> GetSelectedRemindingList(int ID)
        //{
        //    List<RemindingModel> list = new List<RemindingModel>();
        //    list = dao.GetselectedRemindingrecords(ID);
        //    return list;
        //}

        //[HttpGet]
        //public List<RemindingModel> Getoldremindingsforselectedid(int ID)
        //{
        //    List<RemindingModel> list = new List<RemindingModel>();
        //    list = dao.getoldremindingsforid(ID);
        //    return list;
        //}

        //[HttpGet]
        //public List<RemindingModel> Getoldreminding()
        //{
        //    List<RemindingModel> list = new List<RemindingModel>();
        //    list = dao.Getoldremidings();
        //    return list;
        //}

        //[HttpGet]
        //public List<string> Getstatussource()
        //{
        //    List<string> list = new List<string>();
        //    list = dao.Fillstatussource();
        //    return list;
        //}

        //[HttpGet]
        //public List<string> Gettypesource()
        //{
        //    List<string> list = new List<string>();
        //    list = dao.Filltypesource();
        //    return list;
        //}

        //[HttpPost]
        //public bool Add(RemindingModel Obj)
        //{
        //    bool IsAdded = false;

        //    IsAdded = dao.GenericAdd(Obj);

        //    return IsAdded;
        //}

        //[HttpPost]
        //public bool Update(RemindingModel Obj)
        //{
        //    bool Isupdated = false;

        //    Isupdated = dao.GenericUpdate(Obj);

        //    return Isupdated;
        //}

        //[HttpGet]
        //public void Remindingcontrol()
        //{
        //    RemindingUtils remindingUtils = new RemindingUtils();
        //    List<RemindingModel> list = new List<RemindingModel>();
        //    list = dao.GetAllRecords();
        //    foreach (var remindingrecord in list)
        //    {
        //        OrderModel model = new OrderModel();
        //        string status = remindingrecord.Hatırlatmatipi;
        //        switch (status)
        //        {
        //            case "Uygulama Açıldığında Uyarı Göster":

        //                break;
        //            case "Her Saat Başlangıcında Uygulamada Uyarı Göster":

        //                break;
        //            case "Her Hafta Başlangıcında Uygulama Açıldığında Uyarı Göster":

        //                break;
        //            case "Bir defa Mail Gönder":
        //                //bool issent = false;
        //                //model = parsemodel(remindingrecord);
        //                //issent=remindingUtils.mailsend("yildiz655@gmail.com", "123.konZek", model.Eposta, "İnterpol Tercüme Mail Bildirimi", remindingrecord.Hatırlatmamesajı);
        //                //if (issent)
        //                //{
        //                //    remindingrecord.Hatırlatmadurumu = "TAMAMLANDI";
        //                //    remindingDAO.Update(remindingrecord);
        //                //}
        //                //break;
        //            case "Her Saat Başlangıcında Mail Gönder":
        //                model = parsemodel(remindingrecord);
        //                remindingUtils.mailsend("yildiz655@gmail.com", "123.konZek", model.Costumerorder.Eposta, "İnterpol Tercüme Mail Bildirimi", remindingrecord.Hatırlatmamesajı);
        //                break;
        //            case "Her Saat Başlangıcında Mail Gönder (Mesai Saatleri içerisinde)":
        //                if (DateTime.Now.Hour>=8 && DateTime.Now.Hour<18 && DateTime.Now.DayOfWeek.ToString()!= "Sunday" && DateTime.Now.DayOfWeek.ToString() != "Saturday")
        //                {
        //                    model = parsemodel(remindingrecord);
        //                    remindingUtils.mailsend("yildiz655@gmail.com", "123.konZek", model.Costumerorder.Eposta, "İnterpol Tercüme Mail Bildirimi", remindingrecord.Hatırlatmamesajı);
        //                }

        //                break;                  
        //            case "Her Hafta Başlangıcında Mail Gönder":
        //                if (DateTime.Now.DayOfWeek.ToString()=="Monday" && DateTime.Now.Hour==8 )
        //                {
        //                    model = parsemodel(remindingrecord);
        //                    remindingUtils.mailsend("yildiz655@gmail.com", "123.konZek", model.Costumerorder.Eposta, "İnterpol Tercüme Mail Bildirimi", remindingrecord.Hatırlatmamesajı);
        //                }

        //                break;
        //            default:
        //                break;
        //        }
        //    }           
        //}

        //private OrderModel parsemodel(RemindingModel model)
        //{
        //    OrderModel mainmodel = new OrderModel();
        //    mainmodel = dao.Getselectedrecord(model.Anakayıtid);
        //    return mainmodel;
        //}

    }

    class StatusString
    {
        public static string uyg_uyarı = "Uygulama Açıldığında Uyarı Göster";
        public static string uyg_uyarı_eachhour = "Her Saat Başlangıcında Uygulamada Uyarı Göster";
        public static string uyg_uyarı_startweek = "Her Hafta Başlangıcında Uygulama Açıldığında Uyarı Göster";
        public static string uyg_mail = "Uygulama Açıldığında Mail Gönder";
        public static string uyg_mail_eachhour = "Her Saat Başlangıcında Mail Gönder";
        public static string uyg_mail_eachhour1 = "Her Saat Başlangıcında Mail Gönder (Mesai Saatleri içerisinde)";
        public static string uyg_mail_startweek = "Her Hafta Başlangıcında Mail Gönder";
    }

}
