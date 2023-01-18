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
    public partial class customerRegistration : Form
    {
        PostgreSQLFunctions pfunc = new PostgreSQLFunctions();
        string query;
        public customerRegistration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void customerRegistration_Load(object sender, EventArgs e)
        {

        }
        private void setComboBox(string qry, ComboBox combo)
        {
            DataSet ds = pfunc.getDataset(qry);
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                combo.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void allotRoomBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtbox.Text!="" && mobileTxtbox.Text!="" && countryTxtbox.Text!="" && custgenderBox.Text!="" && dobPicker.Text!="" && idTxtbox.Text!="" && addressTxtbox.Text!="" && checkinPicker.Text!="" && bedCombobox.Text!="" && 
                roomTypeCombobox.Text!="" && roomNoCombobox.Text!="" && priceTxtbox.Text!="") {
                query = "select roomid from rooms where roomno = '"+roomNoCombobox.Text+"'";
                NpgsqlDataReader sdr = pfunc.getReaderData(query);
                string rmid = "";
                while (sdr.Read())
                {
                    rmid = sdr[0].ToString();
                }
                query = "insert into customers(name,mobile_no,nationality,gender,date_of_birth,id_proof,address,checkin,roomid) " +
                    "values('" + nameTxtbox.Text + "','" + mobileTxtbox.Text + "','" + countryTxtbox.Text + "','" + custgenderBox.Text + "','" + dobPicker.Text + "','" + idTxtbox.Text + "','" + addressTxtbox.Text + "','" + checkinPicker.Text + "',"+rmid+");"
                    + "update rooms set booked = 'YES' where roomno = '"+roomNoCombobox.Text+"';";
                pfunc.setData(query, "Customer registered successfully!");

                ClearAll();
            }
            else
            {
                MessageBox.Show("All fields are mandatory", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearAll()
        {
            nameTxtbox.Clear();
            mobileTxtbox.Clear();
            countryTxtbox.Clear();
            custgenderBox.SelectedIndex = -1;
            idTxtbox.Clear();
            bedCombobox.SelectedIndex = -1;
            roomTypeCombobox.SelectedIndex = -1;
            roomNoCombobox.SelectedIndex = -1;
            priceTxtbox.Clear();
            addressTxtbox.Clear();
        }

        private void bedCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            roomTypeCombobox.SelectedIndex = -1;
            roomNoCombobox.Items.Clear();
        }

        private void roomTypeCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            query = "select roomno from rooms where bed = '" + bedCombobox.Text + "' and roomtype='" + roomTypeCombobox.Text + "' and booked = 'NO'";
            setComboBox(query, roomNoCombobox);
        }

        private void roomNoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price from rooms where roomno = '" + roomNoCombobox.Text + "' and roomtype = '" + roomTypeCombobox.Text + "';";
            NpgsqlDataReader sdr = pfunc.getReaderData(query);
            while (sdr.Read())
            {
                priceTxtbox.Text = sdr[0].ToString();
            }
            sdr.Close();
        }
    }
}
