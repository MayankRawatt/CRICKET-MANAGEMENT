using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRICKET_MANAGEMENT_DATABASE
{
    public partial class MOST_HUNDREDS : Form
    {
        public MOST_HUNDREDS()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT BNAME,RUNS,HUNDREDS FROM BATSMEN ORDER BY HUNDREDS DESC", con);














                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Show();
            RECORDS r = new RECORDS();
            r.Show();
        }
    }
}
