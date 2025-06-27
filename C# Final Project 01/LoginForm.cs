using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C__Final_Project_01.Controllers;

namespace C__Final_Project_01
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //txt_password.PasswordChar = '*';
        }

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;

            

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                lbl_error.Text = "Please enter username and password.";
                btn_login.Enabled = true;
                return;
            }
            try
            {
                string role = LoginController.Login(username, password);
                if (!string.IsNullOrEmpty(role))
                {
                    this.Hide();
                    var main = new MainForm(); // Dashboard
                    main.Show();
                }
                else
                {
                    lbl_error.Text = "Wrong username or password.";
                    txt_password.Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred during login."+ex.Message);
                // Optionally log ex.Message
            }
            finally
            {
                btn_login.Enabled = true;
            }
        }

      
    }
}
