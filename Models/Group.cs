using ContactManager.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
	class Group
	{
		private MySqlDbConnector db = new MySqlDbConnector();

		public bool AddGroup(int userId, string groupName)
		{
			string query = "INSERT INTO `groups` (`name`, `userid`) VALUES (@gname, @userid)";
			MySqlCommand command = new MySqlCommand(query, db.Connection);

			command.Parameters.Add("@gname", MySqlDbType.VarChar).Value = groupName;
			command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userId;

			db.OpenConnection();

			if (command.ExecuteNonQuery() == 1)
			{
				db.CloseConnection();
				return true;
			}
			else
			{
				db.CloseConnection();
				return false;
			}
		}
		public bool EditGroup(string groupName, int groupId)
		{
			string query = "UPDATE `groups` SET `name`=@gname WHERE `id`=@groupid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@gname", MySqlDbType.VarChar).Value = groupName;
			command.Parameters.Add("@groupid", MySqlDbType.Int32).Value = groupId;
			db.OpenConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.CloseConnection();
				return true;
			}
			else
			{
				db.CloseConnection();
				return false;
			}
		}
		public bool DeleteGroup(int groupId)
		{
			string query = "DELETE FROM `groups` WHERE `id`=@groupid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@groupid", MySqlDbType.Int32).Value = groupId;
			db.OpenConnection();
			if (command.ExecuteNonQuery() == 1)
			{
				db.CloseConnection();
				return true;
			}
			else
			{
				db.CloseConnection();
				return false;
			}
		}
		public DataTable GetAllGroups(int userId)
		{
			string query = "SELECT `id`, `name` FROM `groups` WHERE `userid`=@userid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userId;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable CheckGroupExists(int userId, string groupName)
		{
			string query = "SELECT * FROM `groups` WHERE `name`=@gname AND `userid`=@userid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@gname", MySqlDbType.VarChar).Value = groupName;
			command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userId;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}
