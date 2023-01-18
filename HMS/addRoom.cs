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
    public partial class addRoom : Form
    {
        string query="";
        PostgreSQLFunctions func = new PostgreSQLFunctions();
        public addRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms;";
            DataSet ds = func.getDataset(query);
            roomDatagrid.DataSource = ds.Tables[0];
            roomDatagrid.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_roomButton_Click(object sender, EventArgs e)
        {
            if(roomNum_textbox.Text != "" && bed_type.Text !="" && room_type.Text != "" && price.Text != "")
            {
                string roomno = roomNum_textbox.Text;
                string roomtype = room_type.Text;
                string bedtype = bed_type.Text;
                string roomprice = price.Text;

                string addqry = "insert into rooms(roomno,roomtype,bed,price) values('"+roomno+"','"+roomtype+"','"+bedtype+"','"+roomprice+"')";
                string addRoomMessage = "Room addition";
                func.setData(addqry, addRoomMessage);

                addRoom_Load(this,null);
                addRoomClear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void addRoomClear()
        {
            roomNum_textbox.Clear();
            price.Clear();
            bed_type.SelectedIndex = -1;
            room_type.SelectedIndex = -1;
        }
    }
}
