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
    public partial class INSERT : Form
    {
        public INSERT()
        {
            InitializeComponent();
        }

        private void INSERT_Load(object sender, EventArgs e)
        {
            String connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = con.CreateCommand();

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt1 = new DataTable();
            String connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            sda = new SqlDataAdapter(@"SELECT BID,PID,BNAME,MATCHES,INNINGS,RUNS,AVG,ST,FIFTYS,HUNDREDS,BEST,FOURS,SIXS FROM BATSMEN", con);
            dt1 = new DataTable();
          
            sda.Fill(dt1);

            dataGridView1.DataSource = dt1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
             String connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into BATSMEN(PID,BNAME,MATCHES,INNINGS,RUNS,AVG,ST,FIFTYS,HUNDREDS,BEST,FOURS,SIXS)values('" + pid.Text + "','" + textBox15.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox12.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA UPDATED");
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN M = new ADMIN_LOGIN();
            M.Show();
        }
    }
}