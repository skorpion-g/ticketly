using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticketly.Models;

namespace Ticketly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Tyler" },
                new Customer { Id = 2, Name = "Frankie" },
                new Customer { Id = 3, Name = "Nat" },
                new Customer { Id = 4, Name = "Sean" },
                new Customer { Id = 5, Name = "Dan-L" },
                new Customer { Id = 6, Name = "Aiden" }
            };
        }
    }
}