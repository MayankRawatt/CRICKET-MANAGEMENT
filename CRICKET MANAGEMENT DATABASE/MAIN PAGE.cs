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
using System.Diagnostics;

namespace CRICKET_MANAGEMENT_DATABASE
{
    public partial class mainpage : Form
    {
        private bool waterMarkActive;

        public mainpage()
        {
            InitializeComponent();
            this.waterMarkActive = true;
            this.textBox1.ForeColor = Color.Gray;
            this.textBox1.Text = "Type here";

            this.textBox1.GotFocus += (source, e) =>
            {
                if (this.waterMarkActive)
                {
                    this.waterMarkActive = false;
                    this.textBox1.Text = "";
                    this.textBox1.ForeColor = Color.Black;
                }
            };

            this.textBox1.LostFocus += (source, e) =>
            {
                if (!this.waterMarkActive && string.IsNullOrEmpty(this.textBox1.Text))
                {
                    this.waterMarkActive = true;
                    this.textBox1.Text = "Type here";
                    this.textBox1.ForeColor = Color.Gray;
                }
            };
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;*/
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            string connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
          
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from addinguser where password='" + textBox2.Text + "' and username ='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(textBox2.Text =="mayank"&& textBox1.Text == "mayank123")
            {
                MessageBox.Show("ADMIN LOGIN SUCCESSFUL");
                this.Hide();
                ADMIN_LOGIN a = new ADMIN_LOGIN();
                a.Show();
            }
           else if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("LOGIN SUCCESSFUL");

                this.Hide();
                SECOND ss = new SECOND();
                ss.Show();
              

            }
            else
            {

                MessageBox.Show("INVALID USERNAME OR PASSWORD");

            }
        }
        

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

  
        }

        private void Button5_Click(object sender, EventArgs e)
        {
          
    }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.gmail.com");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            signup SS = new signup();
            SS.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            About A = new About();
            A.Show();
        }

        private void Mainpage_KeyDown(object sender, KeyEventArgs e)
        {
         /*   if(e.KeyCode==Keys.Escape)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }*/
        }
    }
}