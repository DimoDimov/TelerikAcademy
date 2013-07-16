using StudentSystem.Context;
using StudentSystem.Models;
using System;
using System.Data.Entity;
using StudentSystem.Context.Migrations;


namespace StudentSystem.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion
                <StudentSystemContext, Configuration>());

            StudentSystemContext db = new StudentSystemContext();

            var student = new Student
            {
                Name = "Dimitar",
                Number = 1212
            };

            db.Students.Add(student);

            db.SaveChanges();

          
        }
    }
}
