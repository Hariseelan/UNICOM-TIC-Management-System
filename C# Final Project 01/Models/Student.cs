using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    public class Student
    {
        public int StudentID { get; set; }            // Unique identifier for the student
        public string StudentName { get; set; }       // Student's first name
        public DateTime DateOfbirth { get; set; }     // DOB for the student
        public string Email { get; set; }             // Contact email
        public string CourseID { get; set; }          //------ Foreign key to the CourseID this student belongs to ------
    }
}
