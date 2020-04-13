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
    public partial class deletetion : Form
    {
        public deletetion()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            try
            {
                sda = new SqlDataAdapter(@"DELETE FROM BATSMEN WHERE BID='" + textBox1.Text + "'", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("deleted succesfully");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_LOGIN s = new ADMIN_LOGIN();
            s.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter sda;
            DataTable dt;
            sda = new SqlDataAdapter(@"SELECT * FROM BATSMEN", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    } }