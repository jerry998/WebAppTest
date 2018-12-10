using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest.Controllers
{
    [Authorize]
    public class JavaScriptController : Controller
    {

        // GET: JavaScript
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gojs前端圖形化插件()
        {
            return View();
        }

        public ActionResult Gojs自定義流程圖()
        {
            return View();
        }

        public ActionResult Gojs工業流程圖()
        {
            return View();
        }
    }
}