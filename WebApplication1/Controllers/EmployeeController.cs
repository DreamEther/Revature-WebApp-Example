using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public List<Employee> _employeeList = new List<Employee>()
        {
            new Employee
            {
                ID = 1000,
                Name = "Rob"
            },
            new Employee
            {
                ID = 1047,
                Name = "Jackie"
            }
        };

        //Create employee list here...


        // GET: Employee
        public ActionResult Index()
        {
           
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var emp = _employeeList.Where(e => e.ID == id).Single<Employee>();
            // search employee list here and return a single employee based on the id entered
            return View(emp); // would need to pass a single instance of employee by searching an employee list
            //which we would need to create at the top of this class, adding employee instances and hard coding properties
            //eventually we won't be hard coding 
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}