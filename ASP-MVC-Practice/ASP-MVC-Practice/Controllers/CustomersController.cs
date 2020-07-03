using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_Practice.Models;

namespace ASP_MVC_Practice.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult List()
        {
            var customer = new Customer() { Name = "Felix Waweru" };
            return View(customer);
        }
    }
}