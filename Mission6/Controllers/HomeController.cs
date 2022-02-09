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

        public HomeController()
        {

        }

        public IActionResult Index()   // This is our QUADRANTS view Page        update and delete 
        {
            //var tasks = TaskContext.Task

            return View();
        }

        public IActionResult Task()     // Add and edit
        {
            return View();
        }
        


        
    }
}
