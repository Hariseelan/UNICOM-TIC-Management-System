using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Final_Project_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CourseForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new StudentForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TimetableForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_Exam_Click(object sender, EventArgs e)
        {
            new ExamForm().ShowDialog();
        }
        private void btn_Mark_Click(object sender, EventArgs e)
        {
            new MarkForm().ShowDialog();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

       
    }
}
