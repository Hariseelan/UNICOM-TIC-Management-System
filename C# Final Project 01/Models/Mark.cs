using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Final_Project_01.Models
{
    internal class Mark
    {
        public int markID { get; set; }               //------ Unique identifier for the mark entry ------
        public int studentID { get; set; }            //------ The student who received the mark ------
        public int examID { get; set; }               //------ The exam for which the mark was given ------
        public double score { get; set; }             //------ The score or grade obtained ------
    }
}
