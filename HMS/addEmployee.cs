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
    public partial class addEmployee : Form
    {
        string query;
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        public addEmployee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void registerEmpBtn_Click(object sender, EventArgs e)
        {
            if (alrRegCheckbox.Checked)
            {
                query = "update employee set emp_name='"+nameTxtbox.Text+"',emp_mobile='"+mobileTxtbox.Text+"',emp_gender='"+genderCombobox.Text+"' where username = '"+usernameTxtbox.Text+"'";
                sqlfnc.setData(query, "Details updated successfully!");

                ClearAll();
            }
            else
            {
                query = "insert into employee(emp_name,emp_mobile,emp_gender,emp_mail,username,password)" +
                   "values('" + nameTxtbox.Text + "','" + mobileTxtbox.Text + "','" + genderCombobox.Text + "','" + emailTxtbox.Text + "','" + usernameTxtbox.Text + "','" + pwdTxtbox.Text + "')";
                sqlfnc.setData(query, "Employee added succesfully!");

                ClearAll();
            }
        }

        public void ClearAll()
        {
            nameTxtbox.Clear();
            mobileTxtbox.Clear();
            emailTxtbox.Clear();
            usernameTxtbox.Clear();
            pwdTxtbox.Clear();
            genderCombobox.SelectedIndex = -1;
        }
    }
}
