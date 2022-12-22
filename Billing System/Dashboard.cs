using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;

namespace Billing_System
{
    public partial class Dashboard : Form
    {
       

        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qntytext.Text.Length > 0)
                    totaltxt.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(qntytext.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("enter quantity in num");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] array = new string[4];
            array[0] = comboBox.SelectedValue.ToString();
            array[1] = textBox1.Text;
            array[2] = qntytext.Text;
            array[3] = totaltxt.Text;
            ListViewItem lv = new ListViewItem(array);
            if (qntytext.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else {
                listView1.Items.Add(lv);
            }
            try
            {
                subtotal.Text = (Convert.ToInt32(subtotal.Text) + Convert.ToInt32(totaltxt.Text)).ToString();
            }
            catch
            {
              
            }
            //textBox1.Text = "";
            qntytext.Text = "";
            totaltxt.Text = "";
            discountname.Text = "";
            nettotal.Text = "";
            paid_textbox.Text = "";
            balancetxtbox.Text = "";
        }

        private void sweetradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            breadradiobtn.ForeColor = System.Drawing.Color.Green;
            coffeeradiobtn.ForeColor = System.Drawing.Color.Red;
            MySqlConnection con = new MySqlConnection("user id = root; server = localhost; database = billingsystem; pwd=Ncit8439#@");
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select (item_name) from dashboard  where (eatery_type)='bread'", con);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("item_name", typeof(string));
                dt.Load(reader);
                comboBox.ValueMember = "item_name";
                comboBox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
            }


        }

        private void Nettotallbl_Click(object sender, EventArgs e)
        {

        }

        private void Discountlbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {

                 MySqlConnection con = new MySqlConnection("user id = root; server = localhost; database = billingsystem; pwd = Ncit8439#@");
                 MySqlCommand cmd = new MySqlCommand("select * from dashboard where item_name='"+comboBox.SelectedValue.ToString()+"'", con);
                 MySqlDataReader dr;
                 con.Open();
                 dr = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                 while (dr.Read())
                 {
                       
                         string price = dr.GetInt32(3).ToString();
                         textBox1.Text = price;
                          
                         con.Close();

                 }

             


            }
            catch (Exception)
            { }
       }

       private void Dashboard_Load(object sender, EventArgs e)
       {

           MySqlConnection con = new MySqlConnection("user id = root; server = localhost; database = billingsystem; pwd=Ncit8439#@");
         
              try
            {
                  
                    MySqlCommand cmd = new MySqlCommand("select * from dashboard", con);
                    MySqlDataReader reader;
                    con.Open();
                    reader = cmd.ExecuteReader();
                   while(reader.Read())
                {

                    string Itemname = reader.GetString(2);
                    comboBox.Items.Add(Itemname);
                }
            }
            catch (Exception)
            {
            }


        }

        private void coffeeradiobtn_CheckedChanged(object sender, EventArgs e)
       {
           breadradiobtn.ForeColor = System.Drawing.Color.Red;
           coffeeradiobtn.ForeColor = System.Drawing.Color.Green;
           MySqlConnection con = new MySqlConnection("user id = root; server = localhost; database = billingsystem; pwd=Ncit8439#@");
           try
           {
               con.Open();
               MySqlCommand cmd = new MySqlCommand("select (item_name) from dashboard where (eatery_type)='coffee'", con);
               MySqlDataReader reader;
               reader = cmd.ExecuteReader();
               DataTable dt = new DataTable();
               dt.Columns.Add("item_name", typeof(string));
               dt.Load(reader);
               comboBox.ValueMember = "item_name";
               comboBox.DataSource = dt;
               con.Close();
           }
           catch (Exception)
           {
           }

       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {

       }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void subtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (discountname.Text.Length > 0)
                    nettotal.Text = (Convert.ToInt32(subtotal.Text) - Convert.ToInt32(discountname.Text)).ToString();
               
            }
            catch(Exception)
            {
                MessageBox.Show("please enter discount in numbers");
            }
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                for(int i=0;i<listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        try
                        {
                            subtotal.Text = (Convert.ToInt32(subtotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                            listView1.Items[i].Remove();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("please enter correctly");
                        }

                    }
                }

            }
            discountname.Text = "";
            nettotal.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void balancetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paid_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(paid_textbox.Text.Length>0)
                {
                    balancetxtbox.Text = (Convert.ToInt32(paid_textbox.Text) - Convert.ToInt32(nettotal.Text)).ToString();
                }
            }
            catch(Exception)
            {
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            qntytext.Text = "";
           subtotal.Text = "0";
           discountname.Text = "";
           nettotal.Text = "";
           paid_textbox.Text = "";
           balancetxtbox.Text = "";
                   
           }

        private void printbtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            pd.Print();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(listView1.Width, listView1.Height);
            listView1.DrawToBitmap(bitmap, listView1.ClientRectangle);
            e.Graphics.DrawImage(bitmap, new Point(50, 50));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }

      
    }

