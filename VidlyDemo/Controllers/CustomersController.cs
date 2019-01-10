using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyDemo.Models;

namespace VidlyDemo.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { Name = "Amanda Stevic", Id = 1 },
            new Customer { Name = "Aleksandar Djurdjevic", Id = 2 },
        };

        // GET: Customer
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Details(int id)
        {
            if (id < 1 || id > _customers.Count)
                return HttpNotFound();

            return View(_customers[id-1]);


        }

    }
}