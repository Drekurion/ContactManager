using ContactManager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Forms
{
	public partial class ProfileForm : Form
	{
		User user = new User();
		public ProfileForm()
		{
			InitializeComponent();
		}

		private bool CheckEmptyFields()
		{
			bool isEmpty = false;
			if (tbFirstname.Text.Trim().Equals("") || tbLastname.Text.Trim().Equals("") || tbUsername.Text.Trim().Equals(""))
			{
				isEmpty = true;
			}
			return isEmpty;
		}

		private void ProfileForm_Load(object sender, EventArgs e)
		{
			DataTable table = user.GetUserData(Globals.globalID);

			if (table.Rows.Count > 0)
			{
				tbFirstname.Text = table.Rows[0]["firstname"].ToString();
				tbLastname.Text = table.Rows[0]["lastname"].ToString();
				tbUsername.Text = table.Rows[0]["username"].ToString();

				byte[] picture = (byte[])table.Rows[0]["picture"];
				if (picture.Length > 0 && picture != null) // check if picture is loaded
				{
					MemoryStream stream = new MemoryStream(picture);
					pbPicture.Image = Image.FromStream(stream);
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!CheckEmptyFields())
			{
				string firstname = tbFirstname.Text;
				string lastname = tbLastname.Text;
				string username = tbUsername.Text;
				MemoryStream stream = new MemoryStream();
				if (pbPicture.Image != null)
				{
					pbPicture.Image.Save(stream, pbPicture.Image.RawFormat);
				}
				DataTable table = user.CheckUsernameExists(username);
				if (table.Rows.Count <= 0 || Convert.ToInt32(table.Rows[0]["id"]) == Globals.globalID)
				{
					if (user.EditUser(Globals.globalID, firstname, lastname, username, stream))
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("Something went wrong! Action failed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}	
				}
				else
				{
					MessageBox.Show("Username already exists!\nChoose a different one.", "Cannot proceed!", MessageBoxButtons.OK);
				}
			}
			else
			{
				MessageBox.Show("Fill all text fields!", "Cannot proceed!", MessageBoxButtons.OK);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnPicture_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog
			{
				Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
			};
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pbPicture.Image = Image.FromFile(dialog.FileName);
			}
		}

		private void btnPassword_Click(object sender, EventArgs e)
		{
			new PasswordChangeForm().ShowDialog();
		}
	}
}
