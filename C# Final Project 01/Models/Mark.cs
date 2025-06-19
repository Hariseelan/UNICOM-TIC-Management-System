using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    internal class Mark
    {
        public int MarkID { get; set; }               //------ Unique identifier for the mark entry ------
        public int StudentID { get; set; }            //------ The student who received the mark ------
        public int ExamID { get; set; }               //------ The exam for which the mark was given ------
        public double Score { get; set; }             //------ The score or grade obtained ------
    }
}
