using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail; //to send email to the given email address and to get the code//

namespace Billing_System
{
    public partial class SendCode : Form
    {
        string randomcode; //random generated code stored here
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }

        private void SendCode_Load(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();//ramdom number generate garne class 
            randomcode = (rand.Next(999999)).ToString();//variable initiallized with randomnumber
            MailMessage message = new MailMessage();//allows to send email to user
            to = (emailtxt.Text).ToString();//taking the user input from emailtextbox
            from = "ipshaghimire2000@gmail.com";//from where the code is to be send to the user email
            pass = "prasadi12";
            messagebody = "your reset code is " + randomcode;
            message.To.Add(to); //passing the email the user intered where the code is to be sent
            message.From = new MailAddress(from);//from where the code is to be sent
            message.Body = messagebody;
            message.Subject = "password reset code";
            //now sending email through smtp client//
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");//using gmail to send message
            smtp.EnableSsl = true;//security 
            smtp.Port = 587;//port used to send email
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;//email sending through network
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message); //for exception that may occur while sending code message to the user
                MessageBox.Show("code send successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            if (randomcode == (codetxt.Text).ToString())
            {
                to = emailtxt.Text;//passing the email to anaother reset form ie linking another form through email
                Reset_Password rp = new Reset_Password();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("the code is not correct");
            }
        }

        private void codetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendcodepicbox_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform lg = new loginform();
            lg.Show();

        }

        private void describelabel_Click(object sender, EventArgs e)
        {

        }

        private void codelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
