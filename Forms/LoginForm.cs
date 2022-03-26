using ContactManager.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ContactManager.Forms
{
	public partial class LoginForm : Form
	{
		User user = new User();
		public LoginForm()
		{
			InitializeComponent();
		}

		private bool CheckEmptyFields(string kind)
		{
			bool isEmpty = false;
			switch(kind)
			{
				case "signin":
					if(tbFirstname.Text.Trim().Equals("") || tbLastname.Text.Trim().Equals("") || tbSigninUsername.Text.Trim().Equals("") || tbSigninPassword.Text.Trim().Equals(""))
					{
						isEmpty = true;
					}
					break;
				case "login":
					if(tbLoginUsername.Text.Trim().Equals("") || tbLoginPassword.Text.Trim().Equals(""))
					{
						isEmpty = true;
					}
					break;
			}
			return isEmpty;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(!CheckEmptyFields("login")) // check if username and password fields are filled
			{
				string username = tbLoginUsername.Text;
				string password = tbLoginPassword.Text;

				int userid = user.CheckPassword(username, password);

				if (userid > 0)
				{
					Globals.SetGlobalID(userid);
					this.DialogResult = DialogResult.OK;
				}
				else if (userid == -2)
				{
					MessageBox.Show("No connection to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Username or password not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnSignin_Click(object sender, EventArgs e)
		{
			if(!CheckEmptyFields("signin"))
			{
				string firstname = tbFirstname.Text;
				string lastname = tbLastname.Text;
				string username = tbSigninUsername.Text;
				string password = tbSigninPassword.Text;
				MemoryStream stream = new MemoryStream();
				if (pbPicture.Image != null)
				{
					pbPicture.Image.Save(stream, pbPicture.Image.RawFormat);
				}
				DataTable table = user.CheckUsernameExists(username);
				if (table.Rows.Count <= 0)
				{
					if(user.AddNewUser(firstname, lastname, username, password, stream))
					{
						MessageBox.Show("Account created!\nYou can log in now!", "", MessageBoxButtons.OK);
						llbLogin_LinkClicked(null, null);
						tbFirstname.Text = "";
						tbLastname.Text = "";
						tbSigninUsername.Text = "";
						tbSigninPassword.Text = "";
						pbPicture.Image = null;
					}
					else
					{
						MessageBox.Show("Adding an account failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					tbSigninUsername.Text = "";
					MessageBox.Show("Account with this username already exists!\nTry again with a different username.", "Cannot create an account.", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Fill all text fields to create an account!", "Cannot proceed!", MessageBoxButtons.OK);
			}
		}

		private void btnPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
			};
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				pbPicture.Image = Image.FromFile(dialog.FileName);
			}
		}

		private void llbCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			timerSwipeRight.Start();
			llbCreateAccount.Enabled = false;
			llbLogin.Enabled = false;

			//Switching tab control to account creation page
			tbLoginUsername.TabStop = false;
			tbLoginPassword.TabStop = false;
			btnLogin.TabStop = false;

			tbFirstname.TabStop = true;
			tbLastname.TabStop = true;
			tbSigninUsername.TabStop = true;
			tbSigninPassword.TabStop = true;
			btnPicture.TabStop = true;
			btnSignin.TabStop = true;

			this.AcceptButton = btnSignin;
		}

		private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			timerSwipeLeft.Start();
			llbCreateAccount.Enabled = false;
			llbLogin.Enabled = false;

			//Switching tab control to login page
			tbFirstname.TabStop = false;
			tbLastname.TabStop = false;
			tbSigninUsername.TabStop = false;
			tbSigninPassword.TabStop = false;
			btnPicture.TabStop = false;
			btnSignin.TabStop = false;

			tbLoginUsername.TabStop = true;
			tbLoginPassword.TabStop = true;
			btnLogin.TabStop = true;

			this.AcceptButton = btnLogin;
		}
		/// <summary>
		/// Swiping animation to sign in page.
		/// </summary>
		private void timerSwipeRight_Tick(object sender, EventArgs e)
		{
			if(pnBackground.Location.X > -350)
			{
				pnBackground.Location = new Point(pnBackground.Location.X - 10, pnBackground.Location.Y);
			}
			else
			{
				timerSwipeRight.Stop();
				llbCreateAccount.Enabled = true;
				llbLogin.Enabled = true;
			}
		}
		/// <summary>
		/// Swiping animation to log in page.
		/// </summary>
		private void timerSwipeLeft_Tick(object sender, EventArgs e)
		{
			if (pnBackground.Location.X < 0)
			{
				pnBackground.Location = new Point(pnBackground.Location.X + 10, pnBackground.Location.Y);
			}
			else
			{
				timerSwipeLeft.Stop();
				llbCreateAccount.Enabled = true;
				llbLogin.Enabled = true;
			}
		}
	}
}
