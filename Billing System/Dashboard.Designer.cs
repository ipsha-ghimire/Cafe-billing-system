namespace Billing_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bakerysloganlbl = new System.Windows.Forms.Label();
            this.bakerytytlelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coffeeradiobtn = new System.Windows.Forms.RadioButton();
            this.breadradiobtn = new System.Windows.Forms.RadioButton();
            this.exitbtn = new System.Windows.Forms.Button();
            this.Select_itemlbl = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.qntytext = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.itembtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.selectclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalclm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotallbl = new System.Windows.Forms.Label();
            this.Discountlbl = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.discountname = new System.Windows.Forms.TextBox();
            this.nettotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.paidlbl = new System.Windows.Forms.Label();
            this.paid_textbox = new System.Windows.Forms.TextBox();
            this.balancetxtbox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bakerysloganlbl
            // 
            this.bakerysloganlbl.AutoSize = true;
            this.bakerysloganlbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakerysloganlbl.ForeColor = System.Drawing.Color.Sienna;
            this.bakerysloganlbl.Location = new System.Drawing.Point(346, 48);
            this.bakerysloganlbl.Name = "bakerysloganlbl";
            this.bakerysloganlbl.Size = new System.Drawing.Size(151, 21);
            this.bakerysloganlbl.TabIndex = 1;
            this.bakerysloganlbl.Text = "Fresh and Tasty";
            // 
            // bakerytytlelbl
            // 
            this.bakerytytlelbl.AutoSize = true;
            this.bakerytytlelbl.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakerytytlelbl.ForeColor = System.Drawing.Color.Sienna;
            this.bakerytytlelbl.Location = new System.Drawing.Point(290, 9);
            this.bakerytytlelbl.Name = "bakerytytlelbl";
            this.bakerytytlelbl.Size = new System.Drawing.Size(236, 31);
            this.bakerytytlelbl.TabIndex = 2;
            this.bakerytytlelbl.Text = "The Bread House";
            this.bakerytytlelbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // coffeeradiobtn
            // 
            this.coffeeradiobtn.AutoSize = true;
            this.coffeeradiobtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.coffeeradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeradiobtn.ForeColor = System.Drawing.Color.Sienna;
            this.coffeeradiobtn.Location = new System.Drawing.Point(714, 142);
            this.coffeeradiobtn.Name = "coffeeradiobtn";
            this.coffeeradiobtn.Size = new System.Drawing.Size(92, 20);
            this.coffeeradiobtn.TabIndex = 4;
            this.coffeeradiobtn.TabStop = true;
            this.coffeeradiobtn.Text = "COFFEE";
            this.coffeeradiobtn.UseVisualStyleBackColor = false;
            this.coffeeradiobtn.CheckedChanged += new System.EventHandler(this.coffeeradiobtn_CheckedChanged);
            // 
            // breadradiobtn
            // 
            this.breadradiobtn.AutoSize = true;
            this.breadradiobtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.breadradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadradiobtn.ForeColor = System.Drawing.Color.Sienna;
            this.breadradiobtn.Location = new System.Drawing.Point(714, 116);
            this.breadradiobtn.Name = "breadradiobtn";
            this.breadradiobtn.Size = new System.Drawing.Size(83, 20);
            this.breadradiobtn.TabIndex = 5;
            this.breadradiobtn.TabStop = true;
            this.breadradiobtn.Text = "BREAD";
            this.breadradiobtn.UseVisualStyleBackColor = false;
            this.breadradiobtn.CheckedChanged += new System.EventHandler(this.sweetradiobtn_CheckedChanged);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(714, 618);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(87, 31);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_itemlbl
            // 
            this.Select_itemlbl.AutoSize = true;
            this.Select_itemlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_itemlbl.Location = new System.Drawing.Point(96, 160);
            this.Select_itemlbl.Name = "Select_itemlbl";
            this.Select_itemlbl.Size = new System.Drawing.Size(87, 19);
            this.Select_itemlbl.TabIndex = 7;
            this.Select_itemlbl.Text = "Select Item";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.Black;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(189, 156);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(401, 26);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(47, 205);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(38, 16);
            this.pricelbl.TabIndex = 7;
            this.pricelbl.Text = "Price";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.Location = new System.Drawing.Point(202, 209);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(62, 16);
            this.quantitylbl.TabIndex = 7;
            this.quantitylbl.Text = "Quantity";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(366, 212);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(40, 16);
            this.totallbl.TabIndex = 7;
            this.totallbl.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // qntytext
            // 
            this.qntytext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qntytext.Location = new System.Drawing.Point(167, 231);
            this.qntytext.Name = "qntytext";
            this.qntytext.Size = new System.Drawing.Size(129, 20);
            this.qntytext.TabIndex = 9;
            this.qntytext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // totaltxt
            // 
            this.totaltxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totaltxt.Location = new System.Drawing.Point(318, 232);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.ReadOnly = true;
            this.totaltxt.Size = new System.Drawing.Size(135, 20);
            this.totaltxt.TabIndex = 9;
            this.totaltxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // itembtn
            // 
            this.itembtn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.itembtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itembtn.Location = new System.Drawing.Point(658, 228);
            this.itembtn.Name = "itembtn";
            this.itembtn.Size = new System.Drawing.Size(141, 23);
            this.itembtn.TabIndex = 10;
            this.itembtn.Text = "ADD ITEM";
            this.itembtn.UseVisualStyleBackColor = false;
            this.itembtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.NavajoWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.selectclm,
            this.priceclm,
            this.quantityclm,
            this.totalclm});
            this.listView1.Location = new System.Drawing.Point(12, 311);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 260);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // selectclm
            // 
            this.selectclm.Text = "Select item";
            this.selectclm.Width = 178;
            // 
            // priceclm
            // 
            this.priceclm.Text = "Price";
            this.priceclm.Width = 181;
            // 
            // quantityclm
            // 
            this.quantityclm.Text = "Quantity";
            this.quantityclm.Width = 167;
            // 
            // totalclm
            // 
            this.totalclm.Text = "Total";
            this.totalclm.Width = 352;
            // 
            // subtotallbl
            // 
            this.subtotallbl.AutoSize = true;
            this.subtotallbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotallbl.Location = new System.Drawing.Point(47, 579);
            this.subtotallbl.Name = "subtotallbl";
            this.subtotallbl.Size = new System.Drawing.Size(60, 16);
            this.subtotallbl.TabIndex = 7;
            this.subtotallbl.Text = "Subtotal";
            this.subtotallbl.Click += new System.EventHandler(this.Discountlbl_Click);
            // 
            // Discountlbl
            // 
            this.Discountlbl.AutoSize = true;
            this.Discountlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discountlbl.Location = new System.Drawing.Point(186, 579);
            this.Discountlbl.Name = "Discountlbl";
            this.Discountlbl.Size = new System.Drawing.Size(63, 16);
            this.Discountlbl.TabIndex = 7;
            this.Discountlbl.Text = "Discount";
            this.Discountlbl.Click += new System.EventHandler(this.Nettotallbl_Click);
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(12, 598);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(131, 20);
            this.subtotal.TabIndex = 9;
            this.subtotal.Text = "0";
            this.subtotal.TextChanged += new System.EventHandler(this.subtotal_TextChanged);
            // 
            // discountname
            // 
            this.discountname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.discountname.Location = new System.Drawing.Point(149, 598);
            this.discountname.Name = "discountname";
            this.discountname.Size = new System.Drawing.Size(131, 20);
            this.discountname.TabIndex = 9;
            this.discountname.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // nettotal
            // 
            this.nettotal.Location = new System.Drawing.Point(296, 598);
            this.nettotal.Name = "nettotal";
            this.nettotal.Size = new System.Drawing.Size(131, 20);
            this.nettotal.TabIndex = 9;
            this.nettotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Net Total";
            this.label1.Click += new System.EventHandler(this.Nettotallbl_Click);
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(702, 405);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(75, 31);
            this.printbtn.TabIndex = 13;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(702, 375);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 24);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.Location = new System.Drawing.Point(672, 259);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(105, 23);
            this.removebtn.TabIndex = 15;
            this.removebtn.Text = "Remove Item";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Balance";
            // 
            // paidlbl
            // 
            this.paidlbl.AutoSize = true;
            this.paidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidlbl.Location = new System.Drawing.Point(462, 582);
            this.paidlbl.Name = "paidlbl";
            this.paidlbl.Size = new System.Drawing.Size(78, 13);
            this.paidlbl.TabIndex = 19;
            this.paidlbl.Text = "Paid Amount";
            // 
            // paid_textbox
            // 
            this.paid_textbox.Location = new System.Drawing.Point(445, 598);
            this.paid_textbox.Name = "paid_textbox";
            this.paid_textbox.Size = new System.Drawing.Size(100, 20);
            this.paid_textbox.TabIndex = 20;
            this.paid_textbox.TextChanged += new System.EventHandler(this.paid_textbox_TextChanged);
            // 
            // balancetxtbox
            // 
            this.balancetxtbox.Location = new System.Drawing.Point(564, 598);
            this.balancetxtbox.Name = "balancetxtbox";
            this.balancetxtbox.Size = new System.Drawing.Size(100, 20);
            this.balancetxtbox.TabIndex = 21;
            this.balancetxtbox.TextChanged += new System.EventHandler(this.balancetxtbox_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(811, 661);
            this.Controls.Add(this.balancetxtbox);
            this.Controls.Add(this.paid_textbox);
            this.Controls.Add(this.paidlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.itembtn);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.qntytext);
            this.Controls.Add(this.discountname);
            this.Controls.Add(this.nettotal);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Discountlbl);
            this.Controls.Add(this.subtotallbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.Select_itemlbl);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.breadradiobtn);
            this.Controls.Add(this.coffeeradiobtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bakerytytlelbl);
            this.Controls.Add(this.bakerysloganlbl);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bakerysloganlbl;
        private System.Windows.Forms.Label bakerytytlelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton coffeeradiobtn;
        private System.Windows.Forms.RadioButton breadradiobtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label Select_itemlbl;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox qntytext;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button itembtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label subtotallbl;
        private System.Windows.Forms.Label Discountlbl;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.TextBox discountname;
        private System.Windows.Forms.ColumnHeader selectclm;
        private System.Windows.Forms.ColumnHeader priceclm;
        private System.Windows.Forms.ColumnHeader quantityclm;
        private System.Windows.Forms.ColumnHeader totalclm;
        private System.Windows.Forms.TextBox nettotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paidlbl;
        private System.Windows.Forms.TextBox paid_textbox;
        private System.Windows.Forms.TextBox balancetxtbox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}