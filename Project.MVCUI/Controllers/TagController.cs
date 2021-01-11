using Project.BLL.DesignPatterns.RepositoryPattern.ConcRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class TagController : Controller
    {

        TagRepository trep;

        public TagController()
        {
            trep = new TagRepository();
        }


        // GET: Tag
        public ActionResult Index()
        {
            return View();
        }

    }
}