namespace Billing_System
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.companynamelbl = new System.Windows.Forms.Label();
            this.lgnlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.forgetlbl = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.extbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.Sienna;
            this.usernamelbl.Location = new System.Drawing.Point(489, 232);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(69, 16);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "Username";
            // 
            // companynamelbl
            // 
            this.companynamelbl.AutoSize = true;
            this.companynamelbl.Font = new System.Drawing.Font("Aharoni", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.companynamelbl.ForeColor = System.Drawing.Color.Sienna;
            this.companynamelbl.Location = new System.Drawing.Point(451, 55);
            this.companynamelbl.Name = "companynamelbl";
            this.companynamelbl.Size = new System.Drawing.Size(310, 36);
            this.companynamelbl.TabIndex = 1;
            this.companynamelbl.Text = "The Bread House";
            this.companynamelbl.Click += new System.EventHandler(this.companynamelbl_Click);
            // 
            // lgnlbl
            // 
            this.lgnlbl.AutoSize = true;
            this.lgnlbl.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnlbl.ForeColor = System.Drawing.Color.Sienna;
            this.lgnlbl.Location = new System.Drawing.Point(552, 180);
            this.lgnlbl.Name = "lgnlbl";
            this.lgnlbl.Size = new System.Drawing.Size(105, 30);
            this.lgnlbl.TabIndex = 1;
            this.lgnlbl.Text = "login page";
            this.lgnlbl.Click += new System.EventHandler(this.lgnlbl_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.Sienna;
            this.passwordlbl.Location = new System.Drawing.Point(492, 286);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(66, 16);
            this.passwordlbl.TabIndex = 1;
            this.passwordlbl.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.ForeColor = System.Drawing.Color.Sienna;
            this.usernametxt.Location = new System.Drawing.Point(576, 232);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(148, 29);
            this.usernametxt.TabIndex = 3;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.ForeColor = System.Drawing.Color.Sienna;
            this.passwordtxt.Location = new System.Drawing.Point(576, 282);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '.';
            this.passwordtxt.Size = new System.Drawing.Size(148, 29);
            this.passwordtxt.TabIndex = 3;
            // 
            // forgetlbl
            // 
            this.forgetlbl.AutoSize = true;
            this.forgetlbl.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetlbl.ForeColor = System.Drawing.Color.Sienna;
            this.forgetlbl.Location = new System.Drawing.Point(553, 326);
            this.forgetlbl.Name = "forgetlbl";
            this.forgetlbl.Size = new System.Drawing.Size(94, 20);
            this.forgetlbl.TabIndex = 4;
            this.forgetlbl.Text = "forget password";
            this.forgetlbl.Click += new System.EventHandler(this.forgetlbl_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Wheat;
            this.loginbtn.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.loginbtn.Location = new System.Drawing.Point(457, 367);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(101, 37);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // extbtn
            // 
            this.extbtn.BackColor = System.Drawing.Color.Wheat;
            this.extbtn.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.extbtn.Location = new System.Drawing.Point(632, 367);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(107, 37);
            this.extbtn.TabIndex = 5;
            this.extbtn.Text = "Exit";
            this.extbtn.UseVisualStyleBackColor = false;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(557, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(831, 474);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.extbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.forgetlbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.companynamelbl);
            this.Controls.Add(this.lgnlbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.loginform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label companynamelbl;
        private System.Windows.Forms.Label lgnlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label forgetlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

