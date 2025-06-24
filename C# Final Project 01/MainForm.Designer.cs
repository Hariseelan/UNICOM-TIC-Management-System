namespace C__Final_Project_01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_ManagerCourses = new System.Windows.Forms.Button();
            this.btn_ManageStudents = new System.Windows.Forms.Button();
            this.btn_ViewTimetable = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.btn_Mark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ManagerCourses
            // 
            this.btn_ManagerCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ManagerCourses.ForeColor = System.Drawing.Color.Black;
            this.btn_ManagerCourses.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManagerCourses.Image")));
            this.btn_ManagerCourses.Location = new System.Drawing.Point(17, 66);
            this.btn_ManagerCourses.Name = "btn_ManagerCourses";
            this.btn_ManagerCourses.Size = new System.Drawing.Size(251, 39);
            this.btn_ManagerCourses.TabIndex = 0;
            this.btn_ManagerCourses.Text = "Manage Courses";
            this.btn_ManagerCourses.UseVisualStyleBackColor = true;
            this.btn_ManagerCourses.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ManageStudents
            // 
            this.btn_ManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ManageStudents.ForeColor = System.Drawing.Color.Black;
            this.btn_ManageStudents.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageStudents.Image")));
            this.btn_ManageStudents.Location = new System.Drawing.Point(276, 66);
            this.btn_ManageStudents.Name = "btn_ManageStudents";
            this.btn_ManageStudents.Size = new System.Drawing.Size(251, 39);
            this.btn_ManageStudents.TabIndex = 1;
            this.btn_ManageStudents.Text = "Manage Students";
            this.btn_ManageStudents.UseVisualStyleBackColor = true;
            this.btn_ManageStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ViewTimetable
            // 
            this.btn_ViewTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ViewTimetable.ForeColor = System.Drawing.Color.Black;
            this.btn_ViewTimetable.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewTimetable.Image")));
            this.btn_ViewTimetable.Location = new System.Drawing.Point(535, 66);
            this.btn_ViewTimetable.Name = "btn_ViewTimetable";
            this.btn_ViewTimetable.Size = new System.Drawing.Size(251, 39);
            this.btn_ViewTimetable.TabIndex = 2;
            this.btn_ViewTimetable.Text = "View Timetable";
            this.btn_ViewTimetable.UseVisualStyleBackColor = true;
            this.btn_ViewTimetable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_LogOut.ForeColor = System.Drawing.Color.Black;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(274, 242);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(251, 39);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Exam
            // 
            this.btn_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Exam.ForeColor = System.Drawing.Color.Black;
            this.btn_Exam.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exam.Image")));
            this.btn_Exam.Location = new System.Drawing.Point(147, 118);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(251, 34);
            this.btn_Exam.TabIndex = 4;
            this.btn_Exam.Text = "Exam";
            this.btn_Exam.UseVisualStyleBackColor = true;
            this.btn_Exam.Click += new System.EventHandler(this.btn_Exam_Click);
            // 
            // btn_Mark
            // 
            this.btn_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Mark.ForeColor = System.Drawing.Color.Black;
            this.btn_Mark.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mark.Image")));
            this.btn_Mark.Location = new System.Drawing.Point(406, 118);
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.Size = new System.Drawing.Size(251, 34);
            this.btn_Mark.TabIndex = 5;
            this.btn_Mark.Text = "Mark";
            this.btn_Mark.UseVisualStyleBackColor = true;
            this.btn_Mark.Click += new System.EventHandler(this.btn_Mark_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btn_Mark);
            this.Controls.Add(this.btn_Exam);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_ViewTimetable);
            this.Controls.Add(this.btn_ManageStudents);
            this.Controls.Add(this.btn_ManagerCourses);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "MainForm";
            this.Text = "s";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ManagerCourses;
        private System.Windows.Forms.Button btn_ManageStudents;
        private System.Windows.Forms.Button btn_ViewTimetable;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_Mark;
    }
}