namespace C__Final_Project_01
{
    partial class StudentForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.viewstudent = new System.Windows.Forms.DataGridView();
            this.studentid = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 157);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 157);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(254, 157);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // viewstudent
            // 
            this.viewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewstudent.Location = new System.Drawing.Point(39, 203);
            this.viewstudent.Margin = new System.Windows.Forms.Padding(4);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.Size = new System.Drawing.Size(315, 332);
            this.viewstudent.TabIndex = 3;
            this.viewstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // studentid
            // 
            this.studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.studentid.Location = new System.Drawing.Point(146, 17);
            this.studentid.Margin = new System.Windows.Forms.Padding(4);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(208, 23);
            this.studentid.TabIndex = 4;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(146, 49);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(208, 23);
            this.name.TabIndex = 5;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateofbirth.Location = new System.Drawing.Point(146, 81);
            this.dateofbirth.Margin = new System.Windows.Forms.Padding(4);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(208, 23);
            this.dateofbirth.TabIndex = 6;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.Location = new System.Drawing.Point(146, 113);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(208, 23);
            this.email.TabIndex = 7;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentID.Location = new System.Drawing.Point(35, 23);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(74, 17);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(35, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDob.Location = new System.Drawing.Point(35, 87);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(91, 17);
            this.lblDob.TabIndex = 10;
            this.lblDob.Text = "Date of Birth ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(35, 119);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 554);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.name);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView viewstudent;
        private System.Windows.Forms.TextBox studentid;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox dateofbirth;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblEmail;
    }
}