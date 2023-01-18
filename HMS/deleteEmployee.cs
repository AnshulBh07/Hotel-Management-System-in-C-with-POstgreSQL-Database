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
    public partial class deleteEmployee : Form
    {
        PostgreSQLFunctions sqlfnc = new PostgreSQLFunctions();
        string query;
        public deleteEmployee()
        {
            InitializeComponent();
        }

        private void deleteEmployee_Load(object sender, EventArgs e)
        {
            query = "select * from employee";
            DataSet ds = sqlfnc.getDataset(query);
            empDatagrid.DataSource = ds.Tables[0];
        }

        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            query = "delete from employee where empid = '"+empidTxtbox.Text+"'";
            sqlfnc.setData(query, "Employee deleted successfully!");

            deleteEmployee_Load(this,null);
            ClearAll();
        }
        public void ClearAll()
        {
            empidTxtbox.Clear();
        }
    }
}
