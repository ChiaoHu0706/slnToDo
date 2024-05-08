using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjToDo.Models;

namespace prjToDo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        dbToDoEntities db=new dbToDoEntities();
        public ActionResult Index()
        {
            var todos = db.tTodo.OrderByDescending(m=>m.fDate).ToList();
            return View(todos);
        }
    }
}