using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Models;
using MySql.Data.MySqlClient;

namespace ContactManager.Forms
{
	public partial class MainForm : Form
	{
		private Group group = new Group();
		private User user = new User();
		private Contact contact = new Contact();

		public MainForm()
		{
			InitializeComponent();
		}

		private void SetProfile()
		{
			DataTable table = user.GetUserData(Globals.globalID);

			if(table.Rows.Count > 0)
			{
				lbProfileName.Text = table.Rows[0]["firstname"].ToString() + " " + table.Rows[0]["lastname"].ToString();
				byte[] picture = (byte[])table.Rows[0]["picture"];
				if(picture.Length > 0 && picture != null) // check if picture is loaded
				{
					MemoryStream stream = new MemoryStream(picture);
					pbProfilePicture.Image = Image.FromStream(stream);
				}
			}
		}
		private void SetGroups()
		{
			DataTable table = group.GetAllGroups(Globals.globalID);
			dgvGroups.Rows.Clear();

			if (table.Rows.Count > 0)
			{
				foreach(DataRow row in table.Rows)
				{
					dgvGroups.Rows.Add(row["id"].ToString(), row["name"].ToString());
					int groupID = Convert.ToInt32(row["id"]);
				}
			}
		}
		private void SetAllContacts()
		{
			DataTable table = contact.GetAllContacts(Globals.globalID);
			dgvContacts.Rows.Clear();
			if (table.Rows.Count > 0)
			{
				foreach(DataRow row in table.Rows)
				{
					dgvContacts.Rows.Add(row["id"].ToString(), row["firstname"].ToString(), row["lastname"].ToString(), row["phone"].ToString(), row["email"].ToString(), row["address"].ToString());
				}
			}
		}

		

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetProfile();
			SetGroups();
			SetAllContacts();
		}

		private void llbEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProfileForm form = new ProfileForm();
			if(form.ShowDialog() == DialogResult.OK)
			{
				SetProfile();
			}
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			GroupForm form = new GroupForm();
			if(form.ShowDialog()== DialogResult.OK)
			{
				SetGroups();
			}
		}

		private void btnEditGroup_Click(object sender, EventArgs e)
		{
			int groupID = Convert.ToInt32(dgvGroups.CurrentRow.Cells["id"].Value);
			string groupName = dgvGroups.CurrentRow.Cells["name"].Value.ToString();
			GroupForm form = new GroupForm(groupID, groupName);
			if (form.ShowDialog() == DialogResult.OK)
			{
				SetGroups();
			}
		}

		private void btnRemoveGroup_Click(object sender, EventArgs e)
		{
			int groupID = Convert.ToInt32(dgvGroups.CurrentRow.Cells["id"].Value);
			group.DeleteGroup(groupID);
			SetGroups();
		}

		private void btnAddContact_Click(object sender, EventArgs e)
		{
			ContactForm form = new ContactForm();
			if(form.ShowDialog() == DialogResult.OK)
			{
				SetAllContacts();
			}
		}

		private void btnEditContact_Click(object sender, EventArgs e)
		{
			int contactID = Convert.ToInt32(dgvContacts.CurrentRow.Cells["contactid"].Value);
			ContactForm form = new ContactForm(contactID);
			if (form.ShowDialog() == DialogResult.OK)
			{
				SetAllContacts();
			}
		}

		private void btnRemoveContact_Click(object sender, EventArgs e)
		{
			int contactID = Convert.ToInt32(dgvContacts.CurrentRow.Cells["contactid"].Value);
			contact.DeleteContact(contactID);
			SetAllContacts();
		}
	}
}
