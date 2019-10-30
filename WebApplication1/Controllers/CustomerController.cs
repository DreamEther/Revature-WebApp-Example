using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; // need to add this

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1040,
                    Age = 77
                },
                 new Customer()
                {
                    Id = 1042,
                    Age = 55
                },
                  new Customer()
                {
                    Id = 1041,
                    Age = 36
                },
                   new Customer()
                {
                    Id = 740,
                    Age = 20
                }
            };
        public IActionResult Index() // if we need to call index...url will be localhost.44332/Customer/Index
        {
            return View();
        }

        public IActionResult Get() // right click on method name and click add view to add to the current folder
        {
            return View();
        }

        public IActionResult GetOne() // if we want to see the contents of the .cshtml file associated with this method
            // we keep the local url and add /Customer/GetOne
        {
            return View();
        }

        public IActionResult GetTwo(int id)
        {
            // viewBag is only for a single request
            ViewBag.CustomerId = id; // creating CustomerId on the spot
            ViewBag.Message = "This is the customer id";
            return View();
        }

        public IActionResult GetCustomer() // passing a single object
        {
            Customer customer = new Customer()
            {
                Id =110,
                Age = 100
            };

            return View(customer); // View has 4 overloads
            // no parameters, object, or name of view, or a view AND an object
        }

        // passing a collection
        // can create a view with the Template List and type in the Model class to which it will be bound
        //this will generate the view for us so we don't have to write any code 
        public IActionResult GetAllCustomersAutoGenerate() // needs to have the exact same name as the view
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1040,
                    Age = 77
                },
                 new Customer()
                {
                    Id = 1042,
                    Age = 55
                },
                  new Customer()
                {
                    Id = 1041,
                    Age = 36
                },
                   new Customer()
                {
                    Id = 740,
                    Age = 20
                },
        };
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var cust = customers.Where(e => e.Id == id).Single<Customer>();
            // search employee list here and return a single employee based on the id entered
            return View(cust); // would need to pass a single instance of employee by searching an employee list
            //which we would need to create at the top of this class, adding employee instances and hard coding properties
            //eventually we won't be hard coding 
        }
    }
}