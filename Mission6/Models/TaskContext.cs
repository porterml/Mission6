using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        public DbSet<Task> TaskTable { get; set; }  //TaskTable will be the name of the table in the database
        public DbSet<Category> CategoryTable { get; set; } //CategoryTable will be the name of the second table in the database

        //Seed the database with 5 records
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                //List all the other categories you want in the dropdown menu here
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
                );

            mb.Entity<Task>().HasData(

               new Task
               {
                   TaskId = 1,
                   TaskName = "Mow the lawn.",
                   //DueDate = "",
                   Quadrant = 2,
                   CategoryId = 1,
                   Completed = false,

               },
               new Task
               {
                   TaskId = 2,
                   TaskName = "Go to church.",
                   //DueDate = "",
                   Quadrant = 1,
                   CategoryId = 4,
                   Completed = false,
               }

            );
        }
    }
}
             
