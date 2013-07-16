using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace StudentSystem.Context
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() 
            //the name of the base
            :base("StudentSystem")
        { 
        
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
    }
}
