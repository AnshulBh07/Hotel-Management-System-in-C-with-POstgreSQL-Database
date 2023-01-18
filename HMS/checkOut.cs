using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class checkOut : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query;
        public checkOut()
        {
            InitializeComponent();
        }

        private void checkOut_Load(object sender, EventArgs e)
        {
            displayGrid();
        }

        private void displayGrid()
        {
            query = "select a.cust_id,a.name,a.mobile_no,a.checkin,b.roomno,b.bed,b.roomtype,b.price from customers a inner join rooms b on a.roomid = b.roomid where b.booked = 'YES'";
            DataSet ds = sqlfnc.getDataset(query);
            custckoutDatagrid.DataSource = ds.Tables[0];
        }

        private void nameTxtbox_TextChanged(object sender, EventArgs e)
        {
            query = "select a.cust_id,a.name,a.mobile_no,a.checkin,b.roomno,b.bed,b.roomtype,b.price from customers a full join rooms b on a.roomid = b.roomid where b.booked = 'YES' and name ='" + nameTxtbox.Text+"';";
            DataSet ds = sqlfnc.getDataset(query);
            custckoutDatagrid.DataSource = ds.Tables[0];
        }

        private void custckoutDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0 && custckoutDatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                nameTxtbox2.Text = custckoutDatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                roomNoTxtbox.Text = custckoutDatagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtbox2.Text!="" && roomNoTxtbox.Text!="")
            {
                string rmid = "";
                query = "select roomid from rooms where roomno = '" + roomNoTxtbox.Text + "'";
                NpgsqlDataReader sdr = sqlfnc.getReaderData(query);
                while (sdr.Read())
                {
                    rmid = sdr[0].ToString();
                }

                query = "update rooms set booked = 'NO' where roomid = '"+rmid+"';"+
                    "update customers set checkout = '"+checkOutPicker.Text+"',co_status = 'YES' where roomid = '"+rmid+"';";

                sqlfnc.setData(query,"Check Out Successful!");
                displayGrid();

                ClearAll();
            }
            else
            {
                MessageBox.Show("All fields are mandatory!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                displayGrid();
                ClearAll();
            }
        }

        private void ClearAll()
        {
            roomNoTxtbox.Clear();
            nameTxtbox.Clear();
            nameTxtbox2.Clear();
        }
    }
}
