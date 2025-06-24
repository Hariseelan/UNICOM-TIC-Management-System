using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    internal class Subject
    {
        public int subjectID { get; set; }          //------ Unique identifier for the subject ------
        public string subjectName { get; set; }     //------ Name of the subject ------
        public int courseID { get; set; }            //------ Foreign key to the Course this subject belongs to ------
    }
}

