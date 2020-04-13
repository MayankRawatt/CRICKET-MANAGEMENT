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
    public partial class SECOND : Form
    {
        DataTable dt;
        SqlDataAdapter sda;
        public SECOND()
        {
            InitializeComponent();
        }

        private void SECOND_Load(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))

            {

                this.Hide();
                RECORDS ss = new RECORDS();
                ss.Show();


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connection = CommonMethods.GetConnectionString();

            using (SqlConnection con = new SqlConnection(connection))
            {
                this.Hide();
                TEAM_RANKINGS s = new TEAM_RANKINGS();
                s.Show();
               

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            PLAYER_RANKING p = new PLAYER_RANKING();
            p.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainpage MP = new mainpage();
            MP.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          /*  string outputInfo = "";
            string[] keyWords = textBox1.Text.Split(' ');

            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(Name LIKE '%" + word + "%' OR ProductModel LIKE '%" +
                        word + "%' OR Description LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (Name LIKE '%" + word + "%' OR ProductModel LIKE '%" +
                        word + "%' OR Description LIKE '%" + word + "%')";*/

                }
            }
        }
    
