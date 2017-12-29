using MVC_29_Dec_Task.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_29_Dec_Task.Controllers
{
    public class task2Controller : Controller
    {
        // GET: task2
        public ActionResult index()
        {
            EmpDeptViewModel emp = new EmpDeptViewModel
            {
                FirstName = "Rakesh",
                DepartmentName = "Development",
                LastName = "Boya"
            };
            return View(emp);
        }
    }
}