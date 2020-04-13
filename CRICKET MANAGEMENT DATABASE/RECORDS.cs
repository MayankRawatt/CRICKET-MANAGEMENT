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
    public partial class RECORDS : Form
    {
        private object dataGridView1;

        public RECORDS()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_RUNS ss = new MOST_RUNS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT  MAX(RUNS) FROM BATSMEN GROUP BY BID ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            HIGHEST_SCORES N = new HIGHEST_SCORES();
            N.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT BNAME,MATCHES,INNINGS,RUNS,BEST FROM BATSMEN ORDER BY BEST  ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_HUNDREDS ss = new MOST_HUNDREDS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT MAX(HUNDREDS)  FROM BATSMEN GROUP BY BNAME  ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_WICKETS ss = new MOST_WICKETS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT MAX(BEST) FROM BOWLERS GROUP BY NAME ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }


        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            SECOND up = new SECOND();
            up.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_RUNS ss = new MOST_RUNS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                /*  sda = new SqlDataAdapter(@"SELECT * FROM BATSMEN WHERE  ", con);
                  dt = new DataTable();

                  sda.Fill(dt);
                  dataGridView1 = dt;*/
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            NEST_BATTING_AVERAGE ss = new NEST_BATTING_AVERAGE();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT MAX(AVG) FROM BATSMEN GROUP BY BID ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            BEST_BATTING_STRIKE_RATE ss = new BEST_BATTING_STRIKE_RATE();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT MAX(ST) FROM BATSMEN GROUP BY BID ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_FIFTIES ss = new MOST_FIFTIES();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT  MAX(FIFTYS) FROM BATSMEN GROUP BY BID", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_SIXES ss = new MOST_SIXES();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT  MAX(SIXS) FROM BATSMEN GROUP BY BID ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            BEST_BOWLING_AVERAGE ss = new BEST_BOWLING_AVERAGE();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT  MIN(AVG) FROM BOWLERS GROUP BY BID  ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_5_WICKET_HAULS ss = new MOST_5_WICKET_HAULS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT MAX(FIVEWICKET) FROM BOWLERS GROUP BY BID  ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            SqlCommandBuilder scb;
            DataTable dt;

            this.Hide();
            MOST_TEN_WICKET_HAULS ss = new MOST_TEN_WICKET_HAULS();
            ss.Show();
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                sda = new SqlDataAdapter(@"SELECT  MAX(BEST) FROM BOWLERS GROUP BY BID  ", con);
                dt = new DataTable();

                sda.Fill(dt);
                dataGridView1 = dt;
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            PROC o = new PROC();
            o.Show();
            
            }
        }
    
}