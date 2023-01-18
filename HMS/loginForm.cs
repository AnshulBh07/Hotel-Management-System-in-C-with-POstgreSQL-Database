using Npgsql;
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
    public partial class loginForm : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTxtbox.Text != "" && pwdTxtbox.Text!="") {
                string username = usernameTxtbox.Text;
                string password = pwdTxtbox.Text;

                query = "select username,password from employee where username = '"+username+"';";
                NpgsqlDataReader sdr = sqlfnc.getReaderData(query);

                while (sdr.Read())
                {
                    if (usernameTxtbox.Text.Equals(sdr[0].ToString()) && pwdTxtbox.Text.Equals(sdr[1].ToString()))
                    {
                        Dashboard db = new Dashboard();
                        this.Hide();
                        db.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                sdr.Close();
            }
            else
            {
                MessageBox.Show("All fields are mandatory","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            NewRegistration reg = new NewRegistration();
            this.Hide();
            reg.Show();
        }
    }
}
