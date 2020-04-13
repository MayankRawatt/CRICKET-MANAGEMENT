using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRICKET_MANAGEMENT_DATABASE
{
    public partial class PROC : Form
    {
        public PROC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("MYPROC2", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(sqlcmd.ExecuteReader());
                dataGridView1.DataSource = dt;

               

            }
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Show();
            RECORDS r = new RECORDS();
            r.Show();
        }
    }
}
