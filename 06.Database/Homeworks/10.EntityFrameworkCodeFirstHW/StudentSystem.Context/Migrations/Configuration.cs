namespace StudentSystem.Context.Migrations
{
    using StudentSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Context.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemContext context) 
        {            
            context.Students.AddOrUpdate(
                s => s.Name, new Student()
            {
                Name = "Ivan13" + 1,
                Number = 1
            });
            context.SaveChanges();
        }
    }
}
