namespace C__Final_Project_01
{
    partial class TimetableForm
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
            this.lblTimetableID = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimetableID
            // 
            this.lblTimetableID.AutoSize = true;
            this.lblTimetableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTimetableID.Location = new System.Drawing.Point(33, 32);
            this.lblTimetableID.Name = "lblTimetableID";
            this.lblTimetableID.Size = new System.Drawing.Size(79, 17);
            this.lblTimetableID.TabIndex = 0;
            this.lblTimetableID.Text = "Timetble ID";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCourseID.Location = new System.Drawing.Point(33, 68);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(70, 17);
            this.lblCourseID.TabIndex = 1;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSubjectID.Location = new System.Drawing.Point(33, 100);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(72, 17);
            this.lblSubjectID.TabIndex = 2;
            this.lblSubjectID.Text = "Subject ID";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoom.Location = new System.Drawing.Point(33, 132);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(45, 17);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(127, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(127, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(127, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(127, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 23);
            this.textBox4.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 175);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(144, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 175);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 292);
            this.dataGridView1.TabIndex = 11;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblSubjectID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblTimetableID);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimetableID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}