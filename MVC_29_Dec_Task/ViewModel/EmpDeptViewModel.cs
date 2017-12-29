using MVC_29_Dec_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_29_Dec_Task.ModelView
{
    public class EmpDeptViewModel
    {
        Employee e1 = new Employee();

        public string FirstName
        {
            get { return e1.FirstName; }
            set { e1.FirstName = value; }
        }

        public string LastName
        {
            get { return e1.LastName; }
            set { e1.LastName = value; }
        }

        Department d1 = new Department();
 
        public string DepartmentName
        {
            get { return d1.DepartmentName; }
            set { d1.DepartmentName = value; }
        }

    }
}