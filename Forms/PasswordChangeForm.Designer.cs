
namespace ContactManager.Forms
{
	partial class PasswordChangeForm
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
			this.lbOld = new System.Windows.Forms.Label();
			this.lbNew = new System.Windows.Forms.Label();
			this.lbConfirm = new System.Windows.Forms.Label();
			this.tbOld = new System.Windows.Forms.TextBox();
			this.tbNew = new System.Windows.Forms.TextBox();
			this.tbConfirm = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lbTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbOld
			// 
			this.lbOld.AutoSize = true;
			this.lbOld.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbOld.Location = new System.Drawing.Point(9, 58);
			this.lbOld.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbOld.Name = "lbOld";
			this.lbOld.Size = new System.Drawing.Size(117, 22);
			this.lbOld.TabIndex = 1;
			this.lbOld.Text = "Old password:";
			// 
			// lbNew
			// 
			this.lbNew.AutoSize = true;
			this.lbNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbNew.Location = new System.Drawing.Point(8, 89);
			this.lbNew.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbNew.Name = "lbNew";
			this.lbNew.Size = new System.Drawing.Size(127, 22);
			this.lbNew.TabIndex = 2;
			this.lbNew.Text = "New password:";
			// 
			// lbConfirm
			// 
			this.lbConfirm.AutoSize = true;
			this.lbConfirm.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbConfirm.Location = new System.Drawing.Point(8, 120);
			this.lbConfirm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbConfirm.Name = "lbConfirm";
			this.lbConfirm.Size = new System.Drawing.Size(154, 22);
			this.lbConfirm.TabIndex = 3;
			this.lbConfirm.Text = "Confirm password:";
			// 
			// tbOld
			// 
			this.tbOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbOld.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbOld.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbOld.Location = new System.Drawing.Point(170, 57);
			this.tbOld.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbOld.Name = "tbOld";
			this.tbOld.Size = new System.Drawing.Size(160, 23);
			this.tbOld.TabIndex = 0;
			this.tbOld.UseSystemPasswordChar = true;
			// 
			// tbNew
			// 
			this.tbNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbNew.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbNew.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbNew.Location = new System.Drawing.Point(170, 89);
			this.tbNew.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbNew.Name = "tbNew";
			this.tbNew.Size = new System.Drawing.Size(160, 23);
			this.tbNew.TabIndex = 1;
			this.tbNew.UseSystemPasswordChar = true;
			// 
			// tbConfirm
			// 
			this.tbConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.tbConfirm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbConfirm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tbConfirm.Location = new System.Drawing.Point(170, 120);
			this.tbConfirm.Margin = new System.Windows.Forms.Padding(5, 3, 15, 10);
			this.tbConfirm.Name = "tbConfirm";
			this.tbConfirm.Size = new System.Drawing.Size(160, 23);
			this.tbConfirm.TabIndex = 2;
			this.tbConfirm.UseSystemPasswordChar = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.Location = new System.Drawing.Point(9, 165);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(218, 37);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(193)))), ((int)(((byte)(163)))));
			this.btnCancel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancel.Location = new System.Drawing.Point(238, 165);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(107, 37);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
			this.lbTitle.Location = new System.Drawing.Point(82, 9);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(176, 27);
			this.lbTitle.TabIndex = 10;
			this.lbTitle.Text = "Password change";
			// 
			// Password_Change_Form
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(354, 211);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbConfirm);
			this.Controls.Add(this.tbNew);
			this.Controls.Add(this.tbOld);
			this.Controls.Add(this.lbConfirm);
			this.Controls.Add(this.lbNew);
			this.Controls.Add(this.lbOld);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Password_Change_Form";
			this.Text = "Password change";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbOld;
		private System.Windows.Forms.Label lbNew;
		private System.Windows.Forms.Label lbConfirm;
		private System.Windows.Forms.TextBox tbOld;
		private System.Windows.Forms.TextBox tbNew;
		private System.Windows.Forms.TextBox tbConfirm;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lbTitle;
	}
}