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
    public partial class PLAYER_RECORDS : Form
    {
        public PLAYER_RECORDS()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter sda;
            DataTable dt;
            sda = new SqlDataAdapter(@"SELECT * FROM PLAYER", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);

            sda = new SqlDataAdapter(@"UPDATE PLAYER SET  AGE='" + textBox2.Text + "' WHERE PNAME ='" + textBox1.Text + "' ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            MessageBox.Show("UPDATED ");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Show();
            ADMIN_LOGIN s = new ADMIN_LOGIN();
            s.Show();
        }
    }
}
