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
            this.btn_ManagerCourses = new System.Windows.Forms.Button();
            this.btn_ManageStudents = new System.Windows.Forms.Button();
            this.btn_ViewTimetable = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ManagerCourses
            // 
            this.btn_ManagerCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ManagerCourses.Location = new System.Drawing.Point(258, 53);
            this.btn_ManagerCourses.Name = "btn_ManagerCourses";
            this.btn_ManagerCourses.Size = new System.Drawing.Size(237, 43);
            this.btn_ManagerCourses.TabIndex = 0;
            this.btn_ManagerCourses.Text = "Manage Courses";
            this.btn_ManagerCourses.UseVisualStyleBackColor = true;
            this.btn_ManagerCourses.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ManageStudents
            // 
            this.btn_ManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ManageStudents.Location = new System.Drawing.Point(258, 102);
            this.btn_ManageStudents.Name = "btn_ManageStudents";
            this.btn_ManageStudents.Size = new System.Drawing.Size(237, 43);
            this.btn_ManageStudents.TabIndex = 1;
            this.btn_ManageStudents.Text = "Manage Students";
            this.btn_ManageStudents.UseVisualStyleBackColor = true;
            this.btn_ManageStudents.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ViewTimetable
            // 
            this.btn_ViewTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_ViewTimetable.Location = new System.Drawing.Point(258, 151);
            this.btn_ViewTimetable.Name = "btn_ViewTimetable";
            this.btn_ViewTimetable.Size = new System.Drawing.Size(237, 43);
            this.btn_ViewTimetable.TabIndex = 2;
            this.btn_ViewTimetable.Text = "View Timetable";
            this.btn_ViewTimetable.UseVisualStyleBackColor = true;
            this.btn_ViewTimetable.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_LogOut.Location = new System.Drawing.Point(258, 200);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(237, 43);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_ViewTimetable);
            this.Controls.Add(this.btn_ManageStudents);
            this.Controls.Add(this.btn_ManagerCourses);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ManagerCourses;
        private System.Windows.Forms.Button btn_ManageStudents;
        private System.Windows.Forms.Button btn_ViewTimetable;
        private System.Windows.Forms.Button btn_LogOut;
    }
}