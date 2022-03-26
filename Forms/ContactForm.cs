using ContactManager.Models;
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
	public partial class ContactForm : Form
	{
		private readonly int contactID = -1;
		private readonly Contact contact = new Contact();
		public ContactForm()
		{
			InitializeComponent();
		}
		public ContactForm(int contactID)
		{
			InitializeComponent();
			this.contactID = contactID;
			DataTable table = contact.GetContactById(contactID);
			if(table.Rows.Count > 0)
			{
				tbFirstname.Text = table.Rows[0]["firstname"].ToString();
				tbLastname.Text = table.Rows[0]["lastname"].ToString();
				tbPhone.Text = table.Rows[0]["phone"].ToString();
				tbEmail.Text = table.Rows[0]["email"].ToString();
				tbAddress.Text = table.Rows[0]["address"].ToString();
				byte[] picture = (byte[])table.Rows[0]["picture"];

				if (picture.Length > 0 && picture != null) // check if picture is loaded
				{
					MemoryStream stream = new MemoryStream(picture);
					pbPicture.Image = Image.FromStream(stream);
				}
			}
		}


		private bool CheckEmptyFields()
		{
			bool isEmpty = false;
			if (tbFirstname.Text.Trim().Equals("") || tbLastname.Text.Trim().Equals("") || (tbPhone.Text.Trim().Equals("") && tbEmail.Text.Trim().Equals("")))
			{
				isEmpty = true;
			}
			return isEmpty;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Contact contact = new Contact();
			if(!CheckEmptyFields())
			{
				string firstName = tbFirstname.Text;
				string lastName = tbLastname.Text;
				int group = Convert.ToInt32(cbGroup.SelectedValue);
				string phoneNumber = tbPhone.Text;
				string email = tbEmail.Text;
				string address = tbAddress.Text;
				MemoryStream stream = new MemoryStream();
				if (pbPicture.Image != null)
				{
					pbPicture.Image.Save(stream, pbPicture.Image.RawFormat);
				}
				if (contactID < 0) // check if user is adding or editing a contact.
				{
					if(contact.AddContact(Globals.globalID, firstName, lastName, group, phoneNumber, email, address, stream))
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("Contact not created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					if(contact.EditContact(contactID, firstName, lastName, phoneNumber, email, address, stream))
					{
						this.DialogResult = DialogResult.OK;
					}
					else
					{
						MessageBox.Show("Contact not edited.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
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

		private void btnGroups_Click(object sender, EventArgs e)
		{

		}
	}
}
