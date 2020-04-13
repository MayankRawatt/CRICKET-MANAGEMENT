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
    public partial class BEST_BATTING_STRIKE_RATE : Form
    {
        public BEST_BATTING_STRIKE_RATE()
        {
            InitializeComponent();
        }

        private void BEST_BATTING_STRIKE_RATE_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Show();
            RECORDS r = new RECORDS();
            r.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT ST,BNAME FROM BATSMEN ORDER BY ST DESC", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
