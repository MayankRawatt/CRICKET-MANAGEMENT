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
    public partial class UPDATE_TEAM_RANKING : Form
    {
        public UPDATE_TEAM_RANKING()
        {
            InitializeComponent();
        }

        private void UPDATE_TEAM_RANKING_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
             SqlDataAdapter sda;
            DataTable dt;
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
     
                sda = new SqlDataAdapter(@"UPDATE RANKING SET  RANKING='" + textBox2.Text + "' WHERE NAME ='" + textBox1.Text + "' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;


            MessageBox.Show("UPDATED ");

          
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter sda;
            DataTable dt;
            sda = new SqlDataAdapter(@"SELECT * FROM RANKING", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Show();
            ADMIN_LOGIN s = new ADMIN_LOGIN();
            s.Show();
        }
    }
    
}
