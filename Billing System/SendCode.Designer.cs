namespace Billing_System
{
    partial class SendCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCode));
            this.sendcodepicbox = new System.Windows.Forms.PictureBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.verifybtn = new System.Windows.Forms.Button();
            this.emaillbl = new System.Windows.Forms.Label();
            this.codelbl = new System.Windows.Forms.Label();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.describelabel = new System.Windows.Forms.Label();
            this.sendcodepnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sendcodepicbox)).BeginInit();
            this.sendcodepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendcodepicbox
            // 
            this.sendcodepicbox.Image = ((System.Drawing.Image)(resources.GetObject("sendcodepicbox.Image")));
            this.sendcodepicbox.Location = new System.Drawing.Point(379, 3);
            this.sendcodepicbox.Name = "sendcodepicbox";
            this.sendcodepicbox.Size = new System.Drawing.Size(24, 21);
            this.sendcodepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendcodepicbox.TabIndex = 0;
            this.sendcodepicbox.TabStop = false;
            this.sendcodepicbox.Click += new System.EventHandler(this.sendcodepicbox_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(126, 95);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(218, 20);
            this.emailtxt.TabIndex = 1;
            // 
            // sendbtn
            // 
            this.sendbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendbtn.Location = new System.Drawing.Point(126, 121);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 2;
            this.sendbtn.Text = "Send Code";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // verifybtn
            // 
            this.verifybtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.verifybtn.Location = new System.Drawing.Point(126, 199);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(84, 23);
            this.verifybtn.TabIndex = 3;
            this.verifybtn.Text = "Verify ";
            this.verifybtn.UseVisualStyleBackColor = true;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emaillbl.Location = new System.Drawing.Point(72, 96);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(42, 15);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "Email:";
            // 
            // codelbl
            // 
            this.codelbl.AutoSize = true;
            this.codelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codelbl.Location = new System.Drawing.Point(72, 176);
            this.codelbl.Name = "codelbl";
            this.codelbl.Size = new System.Drawing.Size(35, 13);
            this.codelbl.TabIndex = 5;
            this.codelbl.Text = "Code:";
            this.codelbl.Click += new System.EventHandler(this.codelbl_Click);
            // 
            // codetxt
            // 
            this.codetxt.Location = new System.Drawing.Point(126, 173);
            this.codetxt.Multiline = true;
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(209, 20);
            this.codetxt.TabIndex = 1;
            this.codetxt.TextChanged += new System.EventHandler(this.codetxt_TextChanged);
            // 
            // describelabel
            // 
            this.describelabel.AutoSize = true;
            this.describelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.describelabel.Location = new System.Drawing.Point(72, 56);
            this.describelabel.Name = "describelabel";
            this.describelabel.Size = new System.Drawing.Size(251, 16);
            this.describelabel.TabIndex = 6;
            this.describelabel.Text = "Enter your mail to get the verifcation code";
            this.describelabel.Click += new System.EventHandler(this.describelabel_Click);
            // 
            // sendcodepnl
            // 
            this.sendcodepnl.BackColor = System.Drawing.Color.DarkSalmon;
            this.sendcodepnl.Controls.Add(this.label1);
            this.sendcodepnl.Controls.Add(this.sendcodepicbox);
            this.sendcodepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendcodepnl.Location = new System.Drawing.Point(0, 0);
            this.sendcodepnl.Name = "sendcodepnl";
            this.sendcodepnl.Size = new System.Drawing.Size(403, 27);
            this.sendcodepnl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Send Code";
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(403, 322);
            this.Controls.Add(this.sendcodepnl);
            this.Controls.Add(this.describelabel);
            this.Controls.Add(this.codelbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.emailtxt);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendCode";
            this.Load += new System.EventHandler(this.SendCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendcodepicbox)).EndInit();
            this.sendcodepnl.ResumeLayout(false);
            this.sendcodepnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sendcodepicbox;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Button verifybtn;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label codelbl;
        private System.Windows.Forms.TextBox codetxt;
        private System.Windows.Forms.Label describelabel;
        private System.Windows.Forms.Panel sendcodepnl;
        private System.Windows.Forms.Label label1;
    }
}