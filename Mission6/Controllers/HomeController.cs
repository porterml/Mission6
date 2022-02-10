using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private TaskContext newTaskContext { get; set; } //done


        public HomeController(TaskContext name) //done
        {
            newTaskContext = name;
        }



        // done
        public IActionResult Index()   // This is our QUADRANTS view Page        get update and delete 
        {
            // to bring in the stuff on the page we want
            var quad_tasks = newTaskContext.TaskTable
                .Include(x => x.Category)
                //.Where(x => x.Edited == false)
                .OrderBy(x => x.TaskName)
                .ToList(); //create a list to send to the view so it can be output on the page


            return View(quad_tasks);
        }


        // TASK VIEW ===========================================================================================

        [HttpGet] //done
        public IActionResult Task()     //view     Task has the add 
        {
            ViewBag.Categories = newTaskContext.CategoryTable.ToList();


            return View(/*tasks_page*/); //pass along so that the tasks can be read in on the page
        }


        [HttpPost] //done
        public IActionResult Task(Models.Task NT)     // Add 
        {
            if (ModelState.IsValid)
            {
                ViewBag.Categories = newTaskContext.CategoryTable.ToList();


                newTaskContext.Add(NT);
                newTaskContext.SaveChanges();

                return View("Index");
            }
            else
            {
                ViewBag.Categories = newTaskContext.CategoryTable.ToList();

                return View(NT);
            }
        }




        //EDIT FUNCTIONS BELOW HERE ======================================================================================


        [HttpGet] //done
        public IActionResult Update(int TaskId)   // This is our QUADRANTS view Page        update 
        {
            ViewBag.Categories = newTaskContext.CategoryTable.ToList();   // the word after viewbag could be anything you choose

            var delete_task = newTaskContext.TaskTable.Single(x => x.TaskId == TaskId);

            return View("Task", delete_task);
        }


        [HttpPost] //Done
        public IActionResult Update(Models.Task UT)   // This is our QUADRANTS view Page        update 
        {
            newTaskContext.Update(UT);
            newTaskContext.SaveChanges();

            return RedirectToAction("Index");
        }




        // DELETE FUNCTIONS BELOW ===============================================================================================

        [HttpGet] //done
        public IActionResult Delete(int TaskId)   // This is our QUADRANTS view Page        delete 
        {
            var task_item = newTaskContext.TaskTable.Single(x => x.TaskId == TaskId);

            return View(task_item);
        }


        [HttpPost] //done
        public IActionResult Delete (Models.Task DT)   // This is our QUADRANTS view Page        delete 
        {
            newTaskContext.TaskTable.Remove(DT);
            newTaskContext.SaveChanges();

            return Redirect("Index");
        }


    }
}
