using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {


        private TaskContext Task { get; set; }


        public HomeController()
        {

        }




        public IActionResult Index()   // This is our QUADRANTS view Page        update and delete 
        {
            //var tasks = TaskContext.Task

            return View();
        }


        [HttpGet]
        public IActionResult Index()   // This is our QUADRANTS view Page        update and delete 
        {
            //var tasks = TaskContext.Task

            return View();
        }


        [HttpPost]
        public IActionResult Delete (Task td)   // This is our QUADRANTS view Page        update and delete 
        {
            //var tasks = TaskContext.Task

            return View();
        }


        public IActionResult Task()     // Add and edit
        {
            return View();
        }


        [HttpGet]
        public IActionResult Task(Task nt)     // Add 
        {
            if (ModelState.IsValid)
            {
                TaskContext.Add(nt);
                TaskContext.SaveChanges();
            }

            return View();
        }



        [HttpPost]
        public IActionResult Task()     // edit
        {
            return View();
        }





    }
}
