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
    public partial class Employee : Form
    {
        addEmployee add_emp = new addEmployee();
        empDetails emp_det = new empDetails();
        deleteEmployee emp_del = new deleteEmployee();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            add_emp.TopLevel = false;
            emp_panel.Controls.Add(add_emp);
            add_emp.Show();
            emp_del.Hide();
            emp_det.Hide();
        }

        private void newEmployeeBtn_Click(object sender, EventArgs e)
        {
            add_emp.TopLevel = false;
            emp_panel.Controls.Add(add_emp);
            add_emp.Show();
            emp_del.Hide();
            emp_det.Hide();
        }

        private void empDetailsBtn_Click(object sender, EventArgs e)
        {
            emp_det.TopLevel = false;
            emp_panel.Controls.Add(emp_det);
            emp_det.Show();
            emp_del.Hide();
            add_emp.Hide();
        }

        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            emp_del.TopLevel = false;
            emp_panel.Controls.Add(emp_del);
            emp_del.Show();
            add_emp.Hide();
            emp_det.Hide();
        }
    }
}
