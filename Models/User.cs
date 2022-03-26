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
	class User
	{
		private MySqlDbConnector db = new MySqlDbConnector();
		public bool AddNewUser(string firstname, string lastname, string username, string password, MemoryStream picture)
		{
			string query = "INSERT INTO `users` (`firstname`, `lastname`, `username`, `password`, `picture`) VALUES (@fname, @lname, @uname, @passwd, @picture)";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

			command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
			command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
			command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwordHash;
			command.Parameters.Add("@picture", MySqlDbType.Blob).Value = picture.ToArray();

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
		public bool EditUser(int userId, string firstname, string lastname, string username, MemoryStream picture)
		{
			string query = "UPDATE `users` SET `firstname`=@fname, `lastname`=@lname, `username`=@uname, `picture`=@picture WHERE `id`=@userID";
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
			command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
			command.Parameters.Add("@picture", MySqlDbType.Blob).Value = picture.ToArray();
			command.Parameters.Add("@userID", MySqlDbType.UInt32).Value = userId;
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
		public bool EditPassword(int userID, string password)
		{
			string query = "UPDATE `users` SET `password`=@passwd WHERE `id`=@userID";
			string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@userID", MySqlDbType.UInt32).Value = userID;
			command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwordHash;
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
		public DataTable GetUserData(int userId)
		{
			string query = "SELECT * FROM `users` WHERE `id`=@userID";

			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userId;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);

			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		public DataTable CheckUsernameExists(string username)
		{
			string query = "SELECT `id` FROM `users` WHERE `username`=@uname";

			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);

			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		/// <param name="username">Username account to check for.</param>
		/// <param name="password">Plaintext password to check.</param>
		/// <returns>Id of username account or -1 if account not exists.</returns>
		public int CheckPassword(string username, string password)
		{
			string query = "SELECT `id`,`password` FROM `users` WHERE `username`=@uname";

			MySqlCommand command = new MySqlCommand(query, db.Connection);
			command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;

			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			try
			{
				adapter.Fill(table);
			}
			catch (AggregateException)
			{
				return -2;
			}

			if (table.Rows.Count > 0) // check if username exists
			{
				if (BCrypt.Net.BCrypt.Verify(password, table.Rows[0]["password"].ToString())) // check if password is correct
				{
					return Convert.ToInt32(table.Rows[0]["id"].ToString());
				}
			}
			return -1;
		}
	}
}
