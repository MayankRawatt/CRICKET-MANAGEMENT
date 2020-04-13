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
    public partial class MOST_5_WICKET_HAULS : Form
    {
        public MOST_5_WICKET_HAULS()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT 5W, BOWNAME FROM BOWLERS  ORDER BY 5W DESC", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void MOST_5_WICKET_HAULS_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT *FROM BOWLERS  ORDER BY FIVEWICKET DESC", con);

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