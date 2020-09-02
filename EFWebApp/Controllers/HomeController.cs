using EFModelLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFWebApp.Controllers
{
    public class HomeController : Controller
    {
        EFModelLibrary.IBLL.IStudentService studentservice = new EFModelLibrary.BLL.StudentService();
        //定义学生接口     
        public ActionResult Index()
        {
            return View();
        }
        //查询
        public string IndexShow(FormCollection frm) {
          string flag =  HttpUtility.UrlDecode(frm["flag"].ToString());
          string param = HttpUtility.UrlDecode(frm["param"].ToString());
            int totalcount;
            var temp =studentservice.LoadPageEntities<int>(1, 5, out totalcount, c =>true, c => c.Id, true);
            string aa = JsonConvert.SerializeObject(temp);
            return aa;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}