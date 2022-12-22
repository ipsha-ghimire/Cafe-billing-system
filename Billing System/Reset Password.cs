using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Billing_System
{
    public partial class Reset_Password : Form
    {
        private static string connectionString = "server=localhost;user id=root;database=billingsystem;pwd=Ncit8439#@";



        static string email = SendCode.to;//stores value of sendcode class

        public Reset_Password()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void resetpagelbl_Click(object sender, EventArgs e)
        {

        }

        private void pswdresettxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {

              // here the password need to be updated
            if (pswdresettxt.Text == pswdverifytxt.Text)
            {
                string userName = getUserName();
                string sqlQuery ="UPDATE users SET password=@newPassword WHERE userName=@currentUserName";
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\loginDb.mdf;Integrated Security=True;Connect Timeout=30");

                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(sqlQuery,con);
                cmd.Parameters.AddWithValue("@currentUserName",userName);
                cmd.Parameters.AddWithValue("@newPassword", pswdresettxt.Text);
                con.Open();
                cmd.ExecuteNonQuery();//query execute garna
                con.Close();
                MessageBox.Show("Password Changed Sucessfully");

            }
            else
            {
                MessageBox.Show("could not reset password");
            }
           
        }
        static private string getUserName()
        {
            string sqlQuery = "SELECT userName FROM users WHERE email=@currentUserEmail";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@currentUserEmail", email);
            con.Open();
            object returnValue = cmd.ExecuteScalar();
            String userName = returnValue.ToString();

            con.Close();
            return userName;

        }

        private void exitresetpagebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform l = new loginform();
            l.Show();

        }

        private void pswdverifylbl_Click(object sender, EventArgs e)
        {

        }
    }
} 
        
    