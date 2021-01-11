using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class EditorController : Controller
    {
        // GET: Editor

        //Yorumlar
        public ActionResult Index()
        {
            return View();
        }
    }
}