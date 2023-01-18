using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class NewRegistration : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query;
        public NewRegistration()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void NewRegistration_Load(object sender, EventArgs e)
        {
          
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (termsCheckbox.Checked && usernameTxtbox.Text!="" && emailTxtbox.Text!="" && pwdTxtbox.Text!="" && retypeTxtbox.Text!="")
            {
                if (pwdTxtbox.Text.Equals(retypeTxtbox.Text))
                {
                    query = "insert into employee(emp_name,emp_mobile,emp_mail,username,password)" +
                        " values('','','" + emailTxtbox.Text + "','" + usernameTxtbox.Text + "','" + pwdTxtbox.Text + "')";
                    sqlfnc.setData(query, "User registered successfully!");

                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Password does not match!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void ClearAll()
        {
            usernameTxtbox.Clear();
            emailTxtbox.Clear();
            pwdTxtbox.Clear();
            retypeTxtbox.Clear();
        }
    }
}
