using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class customerDetails : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query,field,target;
        public customerDetails()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDetails_Load(object sender, EventArgs e)
        {
            query = "select * from customers;";
            DataSet ds = sqlfnc.getDataset(query);
            custDetails.DataSource = ds.Tables[0];
            custDetails.Show();
        }

        private void searchByCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchByCombobox.SelectedIndex == 0){
                ClearAll();
                searchByTxtbox.PlaceholderText = "Enter Name";
                target = searchByTxtbox.Text;
            }
            else if(searchByCombobox.SelectedIndex == 1)
            {
                ClearAll();
                searchByTxtbox.PlaceholderText = "Enter Mobile Number";
                target = searchByTxtbox.Text;
            }
            else if(searchByCombobox.SelectedIndex == 2)
            {
                ClearAll();
                searchByTxtbox.PlaceholderText = "Enter Room Number";
                target = searchByTxtbox.Text;
            }
        }

        private void searchByTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (searchByCombobox.SelectedIndex == 1)
            {
                query = "select * from customers where mobile_no = '"+target+"'";
                DataSet ds = sqlfnc.getDataset(query);
                custDetails.DataSource = ds.Tables[0];
            }
            else if (searchByCombobox.SelectedIndex == 2)
            {
                query = "select roomid from rooms where roomno = '" + target + "'";
                string rmid = "";
                NpgsqlDataReader sdr = sqlfnc.getReaderData(query);
                while (sdr.Read())
                {
                    rmid = sdr[0].ToString();
                }
                query = "select * from customers where roomid = '" + rmid + "'";
                DataSet ds = sqlfnc.getDataset(query);
                custDetails.DataSource = ds.Tables[0];
            }
            else if(searchByCombobox.SelectedIndex == 0)
            {
                query = "select * from customers where name = '" + target + "'";
                DataSet ds = sqlfnc.getDataset(query);
                custDetails.DataSource = ds.Tables[0];
                custDetails.Show();
            }
        }

        private void ClearAll()
        {
            searchByTxtbox.Clear();
        }
    }
}
