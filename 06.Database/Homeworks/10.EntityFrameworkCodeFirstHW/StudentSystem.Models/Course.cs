using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

//Courses (Name, Description, Materials, etc.)

namespace StudentSystem.Models
{
    [Table("Course")]
    public class Course
    {
        private ICollection<Student> students;

        [Key, Column("CourseId")]
        public int CourseId { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Materials")]
        public string Materials { get; set; }

        public Course() 
        {
            this.students = new HashSet<Student>();
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
