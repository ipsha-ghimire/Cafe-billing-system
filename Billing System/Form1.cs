using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Billing_System
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lgnlbl_Click(object sender, EventArgs e)
        {

        }

        private void forgetlbl_Click(object sender, EventArgs e)
        {
            SendCode sc = new SendCode();
            this.Hide();
            sc.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(/*yo change garne agadi kai drecently banako wala sanga connect garne*/@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\loginDb.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("select * from Login where username='" + usernametxt.Text + "'and password ='" + passwordtxt.Text + "'", con); //query 
            MySqlConnection con = new MySqlConnection("server = localhost; user id = root; database = billingsystem;pwd=Ncit8439#@");
               MySqlDataAdapter sda = new MySqlDataAdapter("select * from users where username='" + usernametxt.Text + "'and password ='" + passwordtxt.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("error while login");
            }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void companynamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
