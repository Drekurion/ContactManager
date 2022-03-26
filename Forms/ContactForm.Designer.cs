
namespace ContactManager.Forms
{
	partial class ContactForm
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
			this.lbFirstname = new System.Windows.Forms.Label();
			this.lbLastname = new System.Windows.Forms.Label();
			this.lbPhone = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.pbPicture = new System.Windows.Forms.PictureBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.tbFirstname = new System.Windows.Forms.TextBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPicture = new System.Windows.Forms.Button();
			this.lbGroup = new System.Windows.Forms.Label();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// lbFirstname
			// 
			this.lbFirstname.AutoSize = true;
			this.lbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbFirstname.Location = new System.Drawing.Point(17, 189);
			this.lbFirstname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbFirstname.Name = "lbFirstname";
			this.lbFirstname.Size = new System.Drawing.Size(98, 22);
			this.lbFirstname.TabIndex = 0;
			this.lbFirstname.Text = "First Name:";
			// 
			// lbLastname
			// 
			this.lbLastname.AutoSize = true;
			this.lbLastname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbLastname.Location = new System.Drawing.Point(17, 221);
			this.lbLastname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbLastname.Name = "lbLastname";
			this.lbLastname.Size = new System.Drawing.Size(95, 22);
			this.lbLastname.TabIndex = 1;
			this.lbLastname.Text = "Last Name:";
			// 
			// lbPhone
			// 
			this.lbPhone.AutoSize = true;
			this.lbPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbPhone.Location = new System.Drawing.Point(17, 253);
			this.lbPhone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(126, 22);
			this.lbPhone.TabIndex = 2;
			this.lbPhone.Text = "Phone Number:";
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbEmail.Location = new System.Drawing.Point(17, 285);
			this.lbEmail.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(57, 22);
			this.lbEmail.TabIndex = 3;
			this.lbEmail.Text = "Email:";
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbAddress.Location = new System.Drawing.Point(17, 317);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(75, 22);
			this.lbAddress.TabIndex = 4;
			this.lbAddress.Text = "Address:";
			// 
			// pbPicture
			// 
			this.pbPicture.BackgroundImage = global::ContactManager.Properties.Resources.users_picture;
			this.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbPicture.Location = new System.Drawing.Point(111, 12);
			this.pbPicture.Name = "pbPicture";
			this.pbPicture.Size = new System.Drawing.Size(130, 128);
			this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbPicture.TabIndex = 5;
			this.pbPicture.TabStop = false;
			this.pbPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// tbPhone
			// 
			this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbPhone.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbPhone.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbPhone.Location = new System.Drawing.Point(149, 252);
			this.tbPhone.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(187, 23);
			this.tbPhone.TabIndex = 2;
			// 
			// tbLastname
			// 
			this.tbLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbLastname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbLastname.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbLastname.Location = new System.Drawing.Point(149, 220);
			this.tbLastname.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(187, 23);
			this.tbLastname.TabIndex = 1;
			// 
			// tbFirstname
			// 
			this.tbFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbFirstname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbFirstname.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbFirstname.Location = new System.Drawing.Point(149, 189);
			this.tbFirstname.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbFirstname.Name = "tbFirstname";
			this.tbFirstname.Size = new System.Drawing.Size(187, 23);
			this.tbFirstname.TabIndex = 0;
			// 
			// tbEmail
			// 
			this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbEmail.Location = new System.Drawing.Point(149, 285);
			this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(187, 23);
			this.tbEmail.TabIndex = 3;
			// 
			// tbAddress
			// 
			this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbAddress.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbAddress.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbAddress.Location = new System.Drawing.Point(149, 317);
			this.tbAddress.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbAddress.Multiline = true;
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(187, 74);
			this.tbAddress.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(19, 406);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(209, 37);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancel.Location = new System.Drawing.Point(237, 406);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(101, 37);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPicture
			// 
			this.btnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnPicture.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPicture.Location = new System.Drawing.Point(244, 12);
			this.btnPicture.Margin = new System.Windows.Forms.Padding(0);
			this.btnPicture.Name = "btnPicture";
			this.btnPicture.Size = new System.Drawing.Size(45, 30);
			this.btnPicture.TabIndex = 9;
			this.btnPicture.Text = "...";
			this.btnPicture.UseVisualStyleBackColor = false;
			this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
			// 
			// lbGroup
			// 
			this.lbGroup.AutoSize = true;
			this.lbGroup.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbGroup.Location = new System.Drawing.Point(17, 157);
			this.lbGroup.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbGroup.Name = "lbGroup";
			this.lbGroup.Size = new System.Drawing.Size(62, 22);
			this.lbGroup.TabIndex = 11;
			this.lbGroup.Text = "Group:";
			// 
			// cbGroup
			// 
			this.cbGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.cbGroup.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(149, 157);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(187, 26);
			this.cbGroup.TabIndex = 12;
			// 
			// Contact_Form
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(358, 458);
			this.Controls.Add(this.cbGroup);
			this.Controls.Add(this.lbGroup);
			this.Controls.Add(this.btnPicture);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.tbFirstname);
			this.Controls.Add(this.tbLastname);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.pbPicture);
			this.Controls.Add(this.lbAddress);
			this.Controls.Add(this.lbEmail);
			this.Controls.Add(this.lbPhone);
			this.Controls.Add(this.lbLastname);
			this.Controls.Add(this.lbFirstname);
			this.Name = "Contact_Form";
			this.Text = "Contact";
			((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbFirstname;
		private System.Windows.Forms.Label lbLastname;
		private System.Windows.Forms.Label lbPhone;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.PictureBox pbPicture;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbLastname;
		private System.Windows.Forms.TextBox tbFirstname;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnPicture;
		private System.Windows.Forms.Label lbGroup;
		private System.Windows.Forms.ComboBox cbGroup;
	}
}