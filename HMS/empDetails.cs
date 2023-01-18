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
    public partial class empDetails : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query;
        public empDetails()
        {
            InitializeComponent();
        }

        private void empDetails_Load(object sender, EventArgs e)
        {
            query = "select * from employee";
            DataSet ds = sqlfnc.getDataset(query);
            empDatagrid.DataSource = ds.Tables[0];
            empDatagrid.Show();
        }
    }
}
