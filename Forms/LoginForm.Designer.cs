
namespace ContactManager.Forms
{
	partial class LoginForm
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
			this.components = new System.ComponentModel.Container();
			this.pnBackground = new System.Windows.Forms.Panel();
			this.llbCreateAccount = new System.Windows.Forms.LinkLabel();
			this.lbPicture = new System.Windows.Forms.Label();
			this.lbLoginTitle = new System.Windows.Forms.Label();
			this.btnPicture = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.tbLoginPassword = new System.Windows.Forms.TextBox();
			this.llbLogin = new System.Windows.Forms.LinkLabel();
			this.lbLastname = new System.Windows.Forms.Label();
			this.btnSignin = new System.Windows.Forms.Button();
			this.lbLoginUsername = new System.Windows.Forms.Label();
			this.lbFirstname = new System.Windows.Forms.Label();
			this.tbLoginUsername = new System.Windows.Forms.TextBox();
			this.tbFirstname = new System.Windows.Forms.TextBox();
			this.lbLoginPassword = new System.Windows.Forms.Label();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.lbSignin = new System.Windows.Forms.Label();
			this.lbSigninUsername = new System.Windows.Forms.Label();
			this.lbSigninPassword = new System.Windows.Forms.Label();
			this.tbSigninPassword = new System.Windows.Forms.TextBox();
			this.tbSigninUsername = new System.Windows.Forms.TextBox();
			this.timerSwipeRight = new System.Windows.Forms.Timer(this.components);
			this.timerSwipeLeft = new System.Windows.Forms.Timer(this.components);
			this.pnBackground.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// pnBackground
			// 
			this.pnBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.pnBackground.Controls.Add(this.llbCreateAccount);
			this.pnBackground.Controls.Add(this.lbPicture);
			this.pnBackground.Controls.Add(this.lbLoginTitle);
			this.pnBackground.Controls.Add(this.btnPicture);
			this.pnBackground.Controls.Add(this.btnLogin);
			this.pnBackground.Controls.Add(this.pbPicture);
			this.pnBackground.Controls.Add(this.tbLoginPassword);
			this.pnBackground.Controls.Add(this.llbLogin);
			this.pnBackground.Controls.Add(this.lbLastname);
			this.pnBackground.Controls.Add(this.btnSignin);
			this.pnBackground.Controls.Add(this.lbLoginUsername);
			this.pnBackground.Controls.Add(this.lbFirstname);
			this.pnBackground.Controls.Add(this.tbLoginUsername);
			this.pnBackground.Controls.Add(this.tbFirstname);
			this.pnBackground.Controls.Add(this.lbLoginPassword);
			this.pnBackground.Controls.Add(this.tbLastname);
			this.pnBackground.Controls.Add(this.lbSignin);
			this.pnBackground.Controls.Add(this.lbSigninUsername);
			this.pnBackground.Controls.Add(this.lbSigninPassword);
			this.pnBackground.Controls.Add(this.tbSigninPassword);
			this.pnBackground.Controls.Add(this.tbSigninUsername);
			this.pnBackground.Location = new System.Drawing.Point(0, 0);
			this.pnBackground.Name = "pnBackground";
			this.pnBackground.Size = new System.Drawing.Size(600, 356);
			this.pnBackground.TabIndex = 0;
			// 
			// llbCreateAccount
			// 
			this.llbCreateAccount.ActiveLinkColor = System.Drawing.Color.RosyBrown;
			this.llbCreateAccount.AutoSize = true;
			this.llbCreateAccount.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.llbCreateAccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.llbCreateAccount.Location = new System.Drawing.Point(4, 314);
			this.llbCreateAccount.Name = "llbCreateAccount";
			this.llbCreateAccount.Size = new System.Drawing.Size(286, 18);
			this.llbCreateAccount.TabIndex = 10;
			this.llbCreateAccount.TabStop = true;
			this.llbCreateAccount.Text = "You don\'t have an account yet? Sign up here! >>";
			this.llbCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateAccount_LinkClicked);
			// 
			// lbPicture
			// 
			this.lbPicture.AutoSize = true;
			this.lbPicture.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbPicture.Location = new System.Drawing.Point(318, 166);
			this.lbPicture.Name = "lbPicture";
			this.lbPicture.Size = new System.Drawing.Size(70, 22);
			this.lbPicture.TabIndex = 13;
			this.lbPicture.Text = "Picture:";
			// 
			// lbLoginTitle
			// 
			this.lbLoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbLoginTitle.AutoSize = true;
			this.lbLoginTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.lbLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLoginTitle.Location = new System.Drawing.Point(114, 21);
			this.lbLoginTitle.Name = "lbLoginTitle";
			this.lbLoginTitle.Size = new System.Drawing.Size(71, 27);
			this.lbLoginTitle.TabIndex = 0;
			this.lbLoginTitle.Text = "Log in";
			// 
			// btnPicture
			// 
			this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnPicture.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPicture.Location = new System.Drawing.Point(519, 166);
			this.btnPicture.Name = "btnPicture";
			this.btnPicture.Size = new System.Drawing.Size(40, 20);
			this.btnPicture.TabIndex = 8;
			this.btnPicture.Text = "...";
			this.btnPicture.UseVisualStyleBackColor = false;
			this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnLogin.Location = new System.Drawing.Point(23, 129);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(242, 32);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// pbPicture
			// 
			this.pbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pbPicture.Location = new System.Drawing.Point(409, 166);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(105, 92);
			this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPicture.TabIndex = 11;
			this.pbPicture.TabStop = false;
			this.pbPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// tbLoginPassword
			// 
			this.tbLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbLoginPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbLoginPassword.Location = new System.Drawing.Point(114, 92);
			this.tbLoginPassword.Name = "tbLoginPassword";
			this.tbLoginPassword.Size = new System.Drawing.Size(151, 23);
			this.tbLoginPassword.TabIndex = 2;
			this.tbLoginPassword.UseSystemPasswordChar = true;
			// 
			// llbLogin
			// 
			this.llbLogin.ActiveLinkColor = System.Drawing.Color.RosyBrown;
			this.llbLogin.AutoSize = true;
			this.llbLogin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.llbLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.llbLogin.Location = new System.Drawing.Point(318, 312);
			this.llbLogin.Name = "llbLogin";
			this.llbLogin.Size = new System.Drawing.Size(247, 18);
			this.llbLogin.TabIndex = 10;
			this.llbLogin.TabStop = true;
			this.llbLogin.Text = "<< Already have an account? Log in here!";
			this.llbLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogin_LinkClicked);
			// 
			// lbLastname
			// 
			this.lbLastname.AutoSize = true;
			this.lbLastname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLastname.Location = new System.Drawing.Point(318, 89);
			this.lbLastname.Name = "lbLastname";
			this.lbLastname.Size = new System.Drawing.Size(95, 22);
			this.lbLastname.TabIndex = 10;
			this.lbLastname.Text = "Last Name:";
			// 
			// btnSignin
			// 
			this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnSignin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnSignin.Location = new System.Drawing.Point(318, 270);
			this.btnSignin.Margin = new System.Windows.Forms.Padding(0);
			this.btnSignin.Name = "btnSignin";
			this.btnSignin.Size = new System.Drawing.Size(241, 32);
			this.btnSignin.TabIndex = 5;
			this.btnSignin.TabStop = false;
			this.btnSignin.Text = "Sign in";
			this.btnSignin.UseVisualStyleBackColor = false;
			this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
			// 
			// lbLoginUsername
			// 
			this.lbLoginUsername.AutoSize = true;
			this.lbLoginUsername.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLoginUsername.Location = new System.Drawing.Point(23, 67);
			this.lbLoginUsername.Name = "lbLoginUsername";
			this.lbLoginUsername.Size = new System.Drawing.Size(91, 22);
			this.lbLoginUsername.TabIndex = 1;
			this.lbLoginUsername.Text = "Username:";
			// 
			// lbFirstname
			// 
			this.lbFirstname.AutoSize = true;
			this.lbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbFirstname.Location = new System.Drawing.Point(318, 64);
			this.lbFirstname.Name = "lbFirstname";
			this.lbFirstname.Size = new System.Drawing.Size(98, 22);
			this.lbFirstname.TabIndex = 9;
			this.lbFirstname.Text = "First Name:";
			// 
			// tbLoginUsername
			// 
			this.tbLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbLoginUsername.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbLoginUsername.Location = new System.Drawing.Point(114, 67);
			this.tbLoginUsername.Name = "tbLoginUsername";
			this.tbLoginUsername.Size = new System.Drawing.Size(151, 23);
			this.tbLoginUsername.TabIndex = 1;
			// 
			// tbFirstname
			// 
			this.tbFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbFirstname.Location = new System.Drawing.Point(409, 64);
			this.tbFirstname.Name = "tbFirstname";
			this.tbFirstname.Size = new System.Drawing.Size(151, 23);
			this.tbFirstname.TabIndex = 1;
			this.tbFirstname.TabStop = false;
			// 
			// lbLoginPassword
			// 
			this.lbLoginPassword.AutoSize = true;
			this.lbLoginPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLoginPassword.Location = new System.Drawing.Point(23, 92);
			this.lbLoginPassword.Name = "lbLoginPassword";
			this.lbLoginPassword.Size = new System.Drawing.Size(87, 22);
			this.lbLoginPassword.TabIndex = 2;
			this.lbLoginPassword.Text = "Password:";
			// 
			// tbLastname
			// 
			this.tbLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbLastname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbLastname.Location = new System.Drawing.Point(409, 89);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(151, 23);
			this.tbLastname.TabIndex = 2;
			this.tbLastname.TabStop = false;
			// 
			// lbSignin
			// 
			this.lbSignin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSignin.AutoSize = true;
			this.lbSignin.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.lbSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbSignin.Location = new System.Drawing.Point(351, 19);
			this.lbSignin.Name = "lbSignin";
			this.lbSignin.Size = new System.Drawing.Size(206, 27);
			this.lbSignin.TabIndex = 0;
			this.lbSignin.Text = "Create new account";
			// 
			// lbSigninUsername
			// 
			this.lbSigninUsername.AutoSize = true;
			this.lbSigninUsername.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbSigninUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbSigninUsername.Location = new System.Drawing.Point(318, 114);
			this.lbSigninUsername.Name = "lbSigninUsername";
			this.lbSigninUsername.Size = new System.Drawing.Size(91, 22);
			this.lbSigninUsername.TabIndex = 1;
			this.lbSigninUsername.Text = "Username:";
			// 
			// lbSigninPassword
			// 
			this.lbSigninPassword.AutoSize = true;
			this.lbSigninPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lbSigninPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbSigninPassword.Location = new System.Drawing.Point(318, 140);
			this.lbSigninPassword.Name = "lbSigninPassword";
			this.lbSigninPassword.Size = new System.Drawing.Size(87, 22);
			this.lbSigninPassword.TabIndex = 2;
			this.lbSigninPassword.Text = "Password:";
			// 
			// tbSigninPassword
			// 
			this.tbSigninPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbSigninPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbSigninPassword.Location = new System.Drawing.Point(409, 140);
			this.tbSigninPassword.Name = "tbSigninPassword";
			this.tbSigninPassword.Size = new System.Drawing.Size(151, 23);
			this.tbSigninPassword.TabIndex = 4;
			this.tbSigninPassword.TabStop = false;
			this.tbSigninPassword.UseSystemPasswordChar = true;
			// 
			// tbSigninUsername
			// 
			this.tbSigninUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbSigninUsername.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
			this.tbSigninUsername.Location = new System.Drawing.Point(409, 114);
			this.tbSigninUsername.Name = "tbSigninUsername";
			this.tbSigninUsername.Size = new System.Drawing.Size(151, 23);
			this.tbSigninUsername.TabIndex = 3;
			this.tbSigninUsername.TabStop = false;
			// 
			// timerSwipeRight
			// 
			this.timerSwipeRight.Interval = 15;
			this.timerSwipeRight.Tick += new System.EventHandler(this.timerSwipeRight_Tick);
			// 
			// timerSwipeLeft
			// 
			this.timerSwipeLeft.Interval = 15;
			this.timerSwipeLeft.Tick += new System.EventHandler(this.timerSwipeLeft_Tick);
			// 
			// Login_Form
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 356);
			this.Controls.Add(this.pnBackground);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Login_Form";
			this.Text = "Login_Form";
			this.pnBackground.ResumeLayout(false);
			this.pnBackground.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnBackground;
		private System.Windows.Forms.Label lbLoginTitle;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tbLoginPassword;
		private System.Windows.Forms.Label lbLoginUsername;
		private System.Windows.Forms.TextBox tbLoginUsername;
		private System.Windows.Forms.Label lbLoginPassword;
		private System.Windows.Forms.Label lbSignin;
		private System.Windows.Forms.Label lbLastname;
		private System.Windows.Forms.Label lbFirstname;
		private System.Windows.Forms.TextBox tbFirstname;
		private System.Windows.Forms.TextBox tbLastname;
		private System.Windows.Forms.Label lbSigninUsername;
		private System.Windows.Forms.Label lbSigninPassword;
		private System.Windows.Forms.TextBox tbSigninPassword;
		private System.Windows.Forms.TextBox tbSigninUsername;
		private System.Windows.Forms.Label lbPicture;
		private System.Windows.Forms.Button btnPicture;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.LinkLabel llbLogin;
		private System.Windows.Forms.Button btnSignin;
		private System.Windows.Forms.LinkLabel llbCreateAccount;
		private System.Windows.Forms.Timer timerSwipeRight;
		private System.Windows.Forms.Timer timerSwipeLeft;
	}
}