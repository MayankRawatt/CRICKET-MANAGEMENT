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
    public partial class signup : Form
    {
        private string connection;
        private object sqlCmd;

        public signup()
        {
            InitializeComponent();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            connection = CommonMethods.GetConnectionString();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string email = txtemail.Text;
            string password = txtusername.Text;

            string mobile = txtmobileno.Text;
            string Username = textBox1.Text;

            DataTable dt = new DataTable();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into addinguser(name,mobileno,email,username,password,conform_password)values('" + txtname.Text + "','" + txtmobileno.Text + "','" + txtemail.Text + "','"+ textBox1.Text + "','" + txtusername.Text + "','"+txtpassword.Text+"')";
        
            if(Username=="mayank123")
            {
                errorProvider1.SetError(textBox1, "USERNAME ALRESDY EXISTS");
            }
            else
            {
                errorProvider1.Dispose();
            }
           
            if(mobile.Length!=10)
            { 
                MessageBox.Show("mobile number should contains only 10 digits");
               
            }
            if(usermail(email)>=1)
            {

            }
           
            if (password.Length >= 10 && numberPass(password) >= 1 && upperCase(password) >= 1)
            {
                if (txtusername.Text != txtpassword.Text)
                {
                    MessageBox.Show("password does not match");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("registered successfully");



                    this.Hide();
                    mainpage m = new mainpage();
                    m.Show();

                }
            }
            else
            {
                MessageBox.Show("PASSWORD IS INVALID" +
                   "MUST CONTAIN MINIMUM 1 UPPERCASE, 1 DIGIT AND PASSWORD MUST BE GREATER THAN 10");
            }
         

        }

        private int usermail(string email)
        {
            int num = 0;
           if(email.Contains("@gamil.com") && email.Contains("@yahoo.com"))
            {
                num++;
                errorProvider1.Dispose();
            }
           else
                {
                errorProvider1.SetError(txtemail, "ENTER VALID MAIL ID");

            }
            return num;
        }

        /*   private string IsDigit(string mobile)
           {
               int num = 0;
               foreach (char ch in mobile)
               {
                   if (char.IsDigit(ch))
                   {
                        num++;

                   }

               }

           }*/

        private int upperCase(string password)
        {
            int num = 0;
            foreach(char CH in password)
            {
                if(char.IsUpper(CH))
                {
                    num++;

                }
            }
            return num;
        }

        private int numberPass(string password)
        {
            int num = 0;
            foreach(char ch in password)
            {
                if(char.IsDigit(ch))
                {
                    num++;

                }

            }
            return num;
        }

        private void selection()
        {
           
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            mainpage mp = new mainpage();
            mp.Show();
           
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void Txtmobileno_TextChanged(object sender, EventArgs e)
        {
           
           
            
        }
        private void Txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}