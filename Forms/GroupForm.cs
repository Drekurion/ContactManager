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
	public partial class GroupForm : Form
	{
		private readonly int groupId = -1;
		public GroupForm()
		{
			InitializeComponent();
		}
		public GroupForm(int groupId, string groupName)
		{
			InitializeComponent();
			this.groupId = groupId;
			this.tbGroupName.Text = groupName;
		}
		private bool CheckEmptyFields()
		{
			if(tbGroupName.Text.Trim().Equals(""))
			{
				return true;
			}
			return false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Group group = new Group();
			if(!CheckEmptyFields())
			{
				DataTable table = group.CheckGroupExists(Globals.globalID, tbGroupName.Text);
				if(groupId < 0) // adding a new group
				{
					if(table.Rows.Count <= 0)
					{
						if (group.AddGroup(Globals.globalID, tbGroupName.Text))
						{
							this.DialogResult = DialogResult.OK;
						}
						else
						{
							MessageBox.Show("Adding a group failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Group with this name already exists.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					if(table.Rows.Count <= 0 || Convert.ToInt32(table.Rows[0]["id"]) == groupId)
					{
						if(group.EditGroup(tbGroupName.Text, groupId))
						{
							this.DialogResult = DialogResult.OK;
						}
						else
						{
							MessageBox.Show("Editing a group failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Group with this name already exists.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Enter a group name.", "Cannot proceed!", MessageBoxButtons.OK);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
