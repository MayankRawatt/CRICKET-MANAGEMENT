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
    public partial class TEAM_RANKINGS : Form
    {
        public TEAM_RANKINGS()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection)) { 
            sda = new SqlDataAdapter(@"SELECT R.NAME,R.RATING,R.RANKING FROM RANKING R,COUNTRY C WHERE C.RID=R.RID ORDER BY R.RANKING ASC", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SECOND s = new SECOND();
            s.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
