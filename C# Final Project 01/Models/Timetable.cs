using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    internal class Timetable
    {
        public int TimetableID { get; set; }            //------ Unique identifier for the timetable entry ------
        public int CourseID { get; set; }               //------ The course this timetable is for ------
        public int SubjectID { get; set; }              //------ Subject scheduled ------
        public int RoomID { get; set; }                 //------ Room where the class/exam will take place ------
    }
}
