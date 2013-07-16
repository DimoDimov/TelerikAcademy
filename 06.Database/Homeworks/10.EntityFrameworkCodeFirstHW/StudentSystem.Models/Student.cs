using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace StudentSystem.Models
{
    [Table("Students")]
    public class Student
    {
        private ICollection<Course> courses;
        
        [Key, Column("StudentId")]
        public int StudentID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Number")]
        public int Number { get; set; }

        public Student() 
        {
            this.courses = new HashSet<Course>();
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
