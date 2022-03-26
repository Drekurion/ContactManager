using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Forms
{
	public partial class PasswordChangeForm : Form
	{
		User user = new User();
		public PasswordChangeForm()
		{
			InitializeComponent();
		}

		private bool CheckEmptyFields()
		{
			bool isEmpty = false;
			if (tbOld.Text.Trim().Equals("") || tbNew.Text.Trim().Equals("") || tbConfirm.Text.Trim().Equals(""))
			{
				isEmpty = true;
			}
			return isEmpty;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if(!CheckEmptyFields())
			{
				DataTable profile = user.GetUserData(Globals.globalID);
				string username = profile.Rows[0]["username"].ToString();
				if(user.CheckPassword(username, tbOld.Text) == Globals.globalID)
				{
					if(tbOld.Text != tbNew.Text)
					{
						if(tbNew.Text == tbConfirm.Text)
						{
							if(user.EditPassword(Globals.globalID, tbNew.Text))
							{
								MessageBox.Show("Password changed.", "Change password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								this.DialogResult = DialogResult.OK;
							}
							else
							{
								MessageBox.Show("Something went wrong.", "Password not changed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("New password do not match confirmation.", "Password not changed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							tbNew.Text = "";
							tbConfirm.Text = "";
						}
					}
					else
					{
						MessageBox.Show("Your new password cannot be your old password!", "Password not changed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						tbNew.Text = "";
						tbConfirm.Text = "";
					}
				}
				else
				{
					MessageBox.Show("Password not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					tbOld.Text = "";
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
	}
}
