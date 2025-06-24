namespace C__Final_Project_01
{
    partial class MarkForm
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
            this.lblMarkID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblExamID = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
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
            // lblMarkID
            // 
            this.lblMarkID.AutoSize = true;
            this.lblMarkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMarkID.Location = new System.Drawing.Point(12, 23);
            this.lblMarkID.Name = "lblMarkID";
            this.lblMarkID.Size = new System.Drawing.Size(63, 17);
            this.lblMarkID.TabIndex = 0;
            this.lblMarkID.Text = "Marks ID";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentID.Location = new System.Drawing.Point(12, 50);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(74, 17);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblExamID
            // 
            this.lblExamID.AutoSize = true;
            this.lblExamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExamID.Location = new System.Drawing.Point(12, 74);
            this.lblExamID.Name = "lblExamID";
            this.lblExamID.Size = new System.Drawing.Size(59, 17);
            this.lblExamID.TabIndex = 2;
            this.lblExamID.Text = "Exam ID";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblScore.Location = new System.Drawing.Point(12, 102);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 17);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(134, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(134, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox3.Location = new System.Drawing.Point(134, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(134, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 23);
            this.textBox4.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(231, 139);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 139);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 139);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 249);
            this.dataGridView1.TabIndex = 11;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblExamID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblMarkID);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblExamID;
        private System.Windows.Forms.Label lblScore;
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