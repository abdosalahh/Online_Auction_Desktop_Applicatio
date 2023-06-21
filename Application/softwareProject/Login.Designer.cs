namespace softwareProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.HaveNotAccountLable = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.LoginPasswordLable = new System.Windows.Forms.Label();
            this.LoginPanelPassword = new System.Windows.Forms.Panel();
            this.logpasstxt = new System.Windows.Forms.TextBox();
            this.LoginUserNameLable = new System.Windows.Forms.Label();
            this.LoginPanelUserName = new System.Windows.Forms.Panel();
            this.logpntxt = new System.Windows.Forms.TextBox();
            this.LoginTitleLable = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.LoginPanelPassword.SuspendLayout();
            this.LoginPanelUserName.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Lavender;
            this.LoginPanel.Controls.Add(this.linkRegister);
            this.LoginPanel.Controls.Add(this.HaveNotAccountLable);
            this.LoginPanel.Controls.Add(this.logbtn);
            this.LoginPanel.Controls.Add(this.LoginPasswordLable);
            this.LoginPanel.Controls.Add(this.LoginPanelPassword);
            this.LoginPanel.Controls.Add(this.LoginUserNameLable);
            this.LoginPanel.Controls.Add(this.LoginPanelUserName);
            this.LoginPanel.Controls.Add(this.LoginTitleLable);
            this.LoginPanel.Location = new System.Drawing.Point(428, 6);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(451, 600);
            this.LoginPanel.TabIndex = 1;
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegister.ForeColor = System.Drawing.Color.DimGray;
            this.linkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkRegister.Location = new System.Drawing.Point(160, 458);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(104, 28);
            this.linkRegister.TabIndex = 7;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToRegister_LinkClicked);
            // 
            // HaveNotAccountLable
            // 
            this.HaveNotAccountLable.AutoSize = true;
            this.HaveNotAccountLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaveNotAccountLable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.HaveNotAccountLable.Location = new System.Drawing.Point(102, 406);
            this.HaveNotAccountLable.Name = "HaveNotAccountLable";
            this.HaveNotAccountLable.Size = new System.Drawing.Size(250, 23);
            this.HaveNotAccountLable.TabIndex = 6;
            this.HaveNotAccountLable.Text = "Don\'t have an account ?";
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logbtn.FlatAppearance.BorderSize = 0;
            this.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logbtn.Font = new System.Drawing.Font("Magneto", 19.8F, System.Drawing.FontStyle.Bold);
            this.logbtn.ForeColor = System.Drawing.Color.White;
            this.logbtn.Location = new System.Drawing.Point(106, 309);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(217, 59);
            this.logbtn.TabIndex = 5;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // LoginPasswordLable
            // 
            this.LoginPasswordLable.AutoSize = true;
            this.LoginPasswordLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordLable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoginPasswordLable.Location = new System.Drawing.Point(19, 209);
            this.LoginPasswordLable.Name = "LoginPasswordLable";
            this.LoginPasswordLable.Size = new System.Drawing.Size(100, 23);
            this.LoginPasswordLable.TabIndex = 4;
            this.LoginPasswordLable.Text = "Password";
            // 
            // LoginPanelPassword
            // 
            this.LoginPanelPassword.BackColor = System.Drawing.Color.SlateBlue;
            this.LoginPanelPassword.Controls.Add(this.logpasstxt);
            this.LoginPanelPassword.ForeColor = System.Drawing.Color.White;
            this.LoginPanelPassword.Location = new System.Drawing.Point(25, 244);
            this.LoginPanelPassword.Name = "LoginPanelPassword";
            this.LoginPanelPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LoginPanelPassword.Size = new System.Drawing.Size(300, 30);
            this.LoginPanelPassword.TabIndex = 3;
            // 
            // logpasstxt
            // 
            this.logpasstxt.BackColor = System.Drawing.Color.White;
            this.logpasstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logpasstxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpasstxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpasstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logpasstxt.Location = new System.Drawing.Point(0, 0);
            this.logpasstxt.Multiline = true;
            this.logpasstxt.Name = "logpasstxt";
            this.logpasstxt.PasswordChar = '*';
            this.logpasstxt.Size = new System.Drawing.Size(300, 27);
            this.logpasstxt.TabIndex = 0;
            // 
            // LoginUserNameLable
            // 
            this.LoginUserNameLable.AutoSize = true;
            this.LoginUserNameLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserNameLable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoginUserNameLable.Location = new System.Drawing.Point(17, 105);
            this.LoginUserNameLable.Name = "LoginUserNameLable";
            this.LoginUserNameLable.Size = new System.Drawing.Size(155, 23);
            this.LoginUserNameLable.TabIndex = 2;
            this.LoginUserNameLable.Text = "Phone Number";
            // 
            // LoginPanelUserName
            // 
            this.LoginPanelUserName.BackColor = System.Drawing.Color.SlateBlue;
            this.LoginPanelUserName.Controls.Add(this.logpntxt);
            this.LoginPanelUserName.ForeColor = System.Drawing.Color.White;
            this.LoginPanelUserName.Location = new System.Drawing.Point(23, 140);
            this.LoginPanelUserName.Name = "LoginPanelUserName";
            this.LoginPanelUserName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.LoginPanelUserName.Size = new System.Drawing.Size(300, 30);
            this.LoginPanelUserName.TabIndex = 1;
            // 
            // logpntxt
            // 
            this.logpntxt.BackColor = System.Drawing.Color.White;
            this.logpntxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logpntxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpntxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpntxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logpntxt.Location = new System.Drawing.Point(0, 0);
            this.logpntxt.Multiline = true;
            this.logpntxt.Name = "logpntxt";
            this.logpntxt.Size = new System.Drawing.Size(300, 27);
            this.logpntxt.TabIndex = 0;
            // 
            // LoginTitleLable
            // 
            this.LoginTitleLable.AutoSize = true;
            this.LoginTitleLable.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLable.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoginTitleLable.Location = new System.Drawing.Point(17, 19);
            this.LoginTitleLable.Name = "LoginTitleLable";
            this.LoginTitleLable.Size = new System.Drawing.Size(104, 40);
            this.LoginTitleLable.TabIndex = 0;
            this.LoginTitleLable.Text = "Login";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.label2);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.ForeColor = System.Drawing.Color.White;
            this.LogoPanel.Location = new System.Drawing.Point(5, 6);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(415, 600);
            this.LogoPanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(66, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "And Classifier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "All You Need Is Here ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.LoginPanelPassword.ResumeLayout(false);
            this.LoginPanelPassword.PerformLayout();
            this.LoginPanelUserName.ResumeLayout(false);
            this.LoginPanelUserName.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label HaveNotAccountLable;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Label LoginPasswordLable;
        private System.Windows.Forms.Panel LoginPanelPassword;
        private System.Windows.Forms.TextBox logpasstxt;
        private System.Windows.Forms.Label LoginUserNameLable;
        private System.Windows.Forms.Panel LoginPanelUserName;
        private System.Windows.Forms.TextBox logpntxt;
        private System.Windows.Forms.Label LoginTitleLable;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}