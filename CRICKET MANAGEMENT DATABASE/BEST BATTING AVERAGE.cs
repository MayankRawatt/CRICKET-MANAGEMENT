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
    public partial class NEST_BATTING_AVERAGE : Form
    {
        public NEST_BATTING_AVERAGE()
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
                sda = new SqlDataAdapter(@"SELECT BNAME,MATCHES,RUNS,AVG FROM BATSMEN ORDER BY AVG DESC", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            }

        private void NEST_BATTING_AVERAGE_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Show();
            RECORDS s = new RECORDS();
s.Show();        }
    }
}
