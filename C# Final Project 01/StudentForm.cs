using C__Final_Project_01.Controllers;
using C__Final_Project_01.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Final_Project_01
{
    public partial class StudentForm : Form
    {
        private readonly StudentController _controller;
        private int selectedId = -1;

        public StudentForm()
        {
            InitializeComponent();
            
            
        }
        /*private async void LoadStudents()
        {

            viewstudent.DataSource = await _controller.GetAllAsync();
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {

        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Parse StudentID
            /*if (!int.TryParse(studentid.Text, out int parsedStudentId))
            {
                MessageBox.Show("Invalid Student ID. Please enter a valid number.");
                return;
            }

            // Parse DateOfbirth
            if (!DateTime.TryParse(dateofbirth.Text, out DateTime parsedDateOfBirth))
            {
                MessageBox.Show("Invalid Date of Birth. Please enter a valid date.");
                return;
            }*/

            Student student = new Student
            {
                StudentID = int.Parse(studentid.Text),
                StudentName = name.Text,
                DateOfbirth = DateTime.Parse(dateofbirth.Text),
                Email = email.Text
            };

        StudentController studentController = new StudentController();
        studentController.AddStudent(student);
        //MessageBox.Show();
        
        }
        

/*        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            var student = new Student
            {
                StudentID = int.Parse(studentid.Text),
                Name = name.Text,
                DateOfbirth = DateTime.Parse(dateofbirth.Text),
                Email = email.Text


            };
            _controller.UpdateAsync(student);
            LoadStudents();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            _controller.DeleteAsync(selectedId);
            LoadStudents();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = viewstudent.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                name.Text = row.Cells["Name"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
            }
        }*/
    }
}
