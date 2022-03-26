using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace ContactManager.Services
{
	class MySqlDbConnector
	{
		private MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

		public MySqlConnection Connection
		{
			get => connection;
		}

		public void OpenConnection()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		public void CloseConnection()
		{
			if (connection.State == ConnectionState.Open)
			{
				connection.Close();
			}
		}
	}
}
