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
    public partial class ADMIN_LOGIN : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public ADMIN_LOGIN()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                this.Hide();
                UPDATE_TEAM_RANKING u = new UPDATE_TEAM_RANKING();
                u.Show();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                this.Hide();
                PLAYER_RECORDS UT = new PLAYER_RECORDS();
                UT.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))


            {
                /*   sda = new SqlDataAdapter(@"SELECT A.NAME,A.M,A.R,A.W,A.AVG,B.NAME,B.RUNS,B.AVG,B.MATCHES,B.FIFTIES,B.HUNDREDS,C.M,C.I,C.AVG,D.PCNAME FROM ALL_ROUNDERS A, BATSMAN B,BOWLERS C,COUNTRY D", con);
                   dt = new DataTable();
                   sda.Fill(dt);
                   dataGridView1.DataSource = dt;*/
            }
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);

            this.Hide();
            INSERT m = new INSERT();
            m.Show();

            /*  using (SqlConnection con = new SqlConnection(connection))


              {
                  sda = new SqlDataAdapter(@"SELECT A.NAME,A.M,A.R,A.W,A.AVG,B.NAME,B.RUNS,B.AVG,B.MATCHES,B.FIFTIES,B.HUNDREDS,C.M,C.I,C.AVG,D.PCNAME FROM ALL_ROUNDERS A, BATSMAN B,BOWLERS C,COUNTRY D", con);
                  dt = new DataTable();
                  sda.Fill(dt);
                  dataGridView1.DataSource = dt;
                  con.Close();
                  MessageBox.Show("PLEASE INSERT YOUR DATA");
              }*/
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))


            {
                this.Hide();
                deletetion d = new deletetion();
                d.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage mp = new mainpage();
            mp.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

    /*    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT *FROM BATSMEN ORDER", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }*/

   /*     private void Button3_Click_1(object sender, EventArgs e)
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
        }*/

        private void ADMIN_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}