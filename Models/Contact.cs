using ContactManager.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
	class Contact
	{
		private MySqlDbConnector db = new MySqlDbConnector();

		public bool AddContact(int userId, string firstName, string lastName, int groupId, string phoneNumber, string email, string address, MemoryStream picture)
		{
			string query = "INSERT INTO `contacts`(`firstname`, `lastname`, `phone`, `email`, `address`, `picture`, `userid`, `groupid`) VALUES (@fname, @lname, @phone, @email, @addr, @pict, @userid, @groupid)";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
			command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
			command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneNumber;
			command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pict", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userId;
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

		public bool EditContact(int contactId, string firstName, string lastName, string phoneNumber, string email, string address, MemoryStream picture)
		{
			string query = "UPDATE `contacts` SET `firstname`=@fname, `lastname`=@lname, `phone`=@phone, `email`=@email, `address`=@addr, `picture`=@pict WHERE `id`=@contactid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
			command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
			command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phoneNumber;
			command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
			command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
			command.Parameters.Add("@pict", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@contactid", MySqlDbType.Int32).Value = contactId;
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

		public bool DeleteContact(int contactId)
		{
			string query = "DELETE FROM `contacts` WHERE `id`=@contactid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@contactid", MySqlDbType.Int32).Value = contactId;
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
		public DataTable GetAllContacts(int userId)
		{
			string query = "SELECT * FROM `contacts` WHERE `userid`=@userid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@userid", MySqlDbType.Int32).Value = userId;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}
		public DataTable GetContactById(int contactId)
		{
			string query = "SELECT * FROM `contacts` WHERE `id`=@contactid";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@contactid", MySqlDbType.Int32).Value = contactId;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}
