using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    internal class Subject
    {
        public int SubjectID { get; set; }          //------ Unique identifier for the subject ------
        public string SubjectName { get; set; }     //------ Name of the subject ------
        public int CourseID { get; set; }            //------ Foreign key to the Course this subject belongs to ------
    }
}

