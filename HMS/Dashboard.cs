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
    public partial class Dashboard : Form
    {
        customerRegistration custrg = new customerRegistration();
        addRoom Add_Room = new addRoom();
        Employee emp = new Employee();
        customerDetails custdet = new customerDetails();
        checkOut ckout = new checkOut();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            add_room_Click(sender, e);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void add_room_Click(object sender, EventArgs e)
        {
            //changing highlight color 
            addRoom_panel.BackColor = Color.AntiqueWhite;
            custDetails_panel.BackColor = Color.Teal;
            checkOut_panel.BackColor = Color.Teal;
            registerCust_panel.BackColor = Color.Teal;
            emp_panel.BackColor = Color.Teal;

            custrg.Hide();
            emp.Hide();
            custdet.Hide();
            ckout.Hide();
            Add_Room.TopLevel = false;
            mainPanel.Controls.Add(Add_Room);
            Add_Room.Show();
        }

        private void register_customer_Click(object sender, EventArgs e)
        {
            addRoom_panel.BackColor = Color.Teal;
            custDetails_panel.BackColor = Color.Teal;
            checkOut_panel.BackColor = Color.Teal;
            registerCust_panel.BackColor = Color.AntiqueWhite;
            emp_panel.BackColor = Color.Teal;

            Add_Room.Hide();
            emp.Hide();
            custdet.Hide();
            ckout.Hide();
            custrg.TopLevel = false;
            mainPanel.Controls.Add(custrg);
            custrg.Show();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            addRoom_panel.BackColor = Color.Teal;
            custDetails_panel.BackColor = Color.Teal;
            checkOut_panel.BackColor = Color.AntiqueWhite;
            registerCust_panel.BackColor = Color.Teal;
            emp_panel.BackColor = Color.Teal;

            Add_Room.Hide();
            emp.Hide();
            custdet.Hide();
            custrg.Hide();
            ckout.TopLevel = false;
            mainPanel.Controls.Add(ckout);
            ckout.Show();
        }

        private void customer_details_Click(object sender, EventArgs e)
        {
            addRoom_panel.BackColor = Color.Teal;
            custDetails_panel.BackColor = Color.AntiqueWhite;
            checkOut_panel.BackColor = Color.Teal;
            registerCust_panel.BackColor = Color.Teal;
            emp_panel.BackColor = Color.Teal;

            Add_Room.Hide();
            emp.Hide();
            custrg.Hide();
            ckout.Hide();
            custdet.TopLevel = false;
            mainPanel.Controls.Add(custdet);
            custdet.Show();
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            addRoom_panel.BackColor = Color.Teal;
            custDetails_panel.BackColor = Color.Teal;
            checkOut_panel.BackColor = Color.Teal;
            registerCust_panel.BackColor = Color.Teal;
            emp_panel.BackColor = Color.AntiqueWhite;

            Add_Room.Hide();
            custrg.Hide();
            custdet.Hide();
            ckout.Hide();
            emp.TopLevel = false;
            mainPanel.Controls.Add(emp);
            emp.Show();
        }
    }
}
