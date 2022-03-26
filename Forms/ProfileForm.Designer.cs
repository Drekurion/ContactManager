
namespace ContactManager.Forms
{
	partial class ProfileForm
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
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.tbFirstname = new System.Windows.Forms.TextBox();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.lbLastname = new System.Windows.Forms.Label();
			this.lbFirstname = new System.Windows.Forms.Label();
			this.tbUsername = new System.Windows.Forms.TextBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnPicture = new System.Windows.Forms.Button();
			this.btnPassword = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// pbPicture
			// 
			this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbPicture.BackgroundImage = global::ContactManager.Properties.Resources.users_picture;
			this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbPicture.Location = new System.Drawing.Point(15, 12);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(123, 109);
			this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPicture.TabIndex = 6;
			this.pbPicture.TabStop = false;
			this.pbPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// tbFirstname
			// 
			this.tbFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbFirstname.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbFirstname.Location = new System.Drawing.Point(141, 147);
			this.tbFirstname.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbFirstname.Name = "tbFirstname";
			this.tbFirstname.Size = new System.Drawing.Size(187, 23);
			this.tbFirstname.TabIndex = 1;
			// 
			// tbLastname
			// 
			this.tbLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbLastname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbLastname.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbLastname.Location = new System.Drawing.Point(141, 178);
			this.tbLastname.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(187, 23);
			this.tbLastname.TabIndex = 2;
			// 
			// lbLastname
			// 
			this.lbLastname.AutoSize = true;
			this.lbLastname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLastname.Location = new System.Drawing.Point(15, 179);
			this.lbLastname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbLastname.Name = "lbLastname";
			this.lbLastname.Size = new System.Drawing.Size(95, 22);
			this.lbLastname.TabIndex = 10;
			this.lbLastname.Text = "Last Name:";
			// 
			// lbFirstname
			// 
			this.lbFirstname.AutoSize = true;
			this.lbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbFirstname.Location = new System.Drawing.Point(15, 147);
			this.lbFirstname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbFirstname.Name = "lbFirstname";
			this.lbFirstname.Size = new System.Drawing.Size(98, 22);
			this.lbFirstname.TabIndex = 8;
			this.lbFirstname.Text = "First Name:";
			// 
			// tbUsername
			// 
			this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbUsername.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbUsername.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbUsername.Location = new System.Drawing.Point(141, 209);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.Size = new System.Drawing.Size(187, 23);
			this.tbUsername.TabIndex = 3;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbUsername.Location = new System.Drawing.Point(15, 209);
			this.lbUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(91, 22);
			this.lbUsername.TabIndex = 12;
			this.lbUsername.Text = "Username:";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancel.Location = new System.Drawing.Point(226, 322);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 37);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(15, 322);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(211, 37);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnPicture
			// 
			this.btnPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnPicture.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPicture.Location = new System.Drawing.Point(141, 12);
			this.btnPicture.Margin = new System.Windows.Forms.Padding(0);
			this.btnPicture.Name = "btnPicture";
			this.btnPicture.Size = new System.Drawing.Size(45, 30);
			this.btnPicture.TabIndex = 0;
			this.btnPicture.Text = "...";
			this.btnPicture.UseVisualStyleBackColor = false;
			this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// btnPassword
			// 
			this.btnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnPassword.Location = new System.Drawing.Point(141, 246);
			this.btnPassword.Margin = new System.Windows.Forms.Padding(0);
			this.btnPassword.Name = "btnPassword";
			this.btnPassword.Size = new System.Drawing.Size(187, 29);
			this.btnPassword.TabIndex = 4;
			this.btnPassword.Text = "Change password";
			this.btnPassword.UseVisualStyleBackColor = false;
			this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
			// 
			// Profile_Form
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(338, 368);
			this.Controls.Add(this.btnPassword);
			this.Controls.Add(this.btnPicture);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbUsername);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.tbFirstname);
			this.Controls.Add(this.tbLastname);
			this.Controls.Add(this.lbLastname);
			this.Controls.Add(this.lbFirstname);
			this.Controls.Add(this.pbPicture);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Profile_Form";
			this.Text = "Your profile:";
			this.Load += new System.EventHandler(this.ProfileForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.TextBox tbFirstname;
		private System.Windows.Forms.TextBox tbLastname;
		private System.Windows.Forms.Label lbLastname;
		private System.Windows.Forms.Label lbFirstname;
		private System.Windows.Forms.TextBox tbUsername;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnPicture;
		private System.Windows.Forms.Button btnPassword;
	}
}