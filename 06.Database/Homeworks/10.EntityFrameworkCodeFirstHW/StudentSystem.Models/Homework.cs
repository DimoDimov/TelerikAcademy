using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

//Using c0de first approach, create database for student system with the following tables:
//Students (with Id, Name, Number, etc.)

//StudentsInCourses (many-to-many relationship)
//Homework (one-to-many relationship with students and courses), fields: Content, TimeSent
//Annotate the data models with the appropriate attributes and enable code first migrations


namespace StudentSystem.Models
{
    [Table("Homeworks")]
    public class Homework
    {
        [Key, Column("HomeworkId")]
        public int HomeworkId { get; set; }

        [Column("Content")]
        public string Content { get; set; }

        [Column("TimeSent")]
        public DateTime TimeSent { get; set; }

        [ForeignKey("Course"), Column("CourseId")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Student"), Column("StudentId")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
