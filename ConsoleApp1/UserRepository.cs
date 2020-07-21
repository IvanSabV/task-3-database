using System;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{

	public class UserRepository
	{
		public string GetUserById()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT name FROM UserDataModel WHERE id = 1";

			SqlCommand command = new SqlCommand(sql, conn);

			string name = command.ExecuteScalar().ToString();

			Console.WriteLine(name);

			return null;

		}
				
		public string GetUserByName()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT id,name FROM UserDataModel WHERE name = 'admin'";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while(reader.Read())
            {
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
			}
			reader.Close();

			return null;
			
		}
		public string SearchUserByName()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT * FROM UserDataModel WHERE name like 'ea%'";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
			}
			reader.Close();

			return null;

		}
		
		public string AddUser()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT max(id)+1 FROM UserDatamodel INSERT INTO UserDatamodel VALUES(alex, 'pass', 1)";

			SqlCommand command = new SqlCommand(sql, conn);


			return null;
		}

		public string UpdateUser()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "UPDATE userDataModel SET name = 'alex' WHERE id = 7";

			SqlCommand command = new SqlCommand(sql, conn);



			return null;

		}
		
		public string UpdateUserState()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "UPDATE userDataModel SET state = 0 WHERE id = 4 SELECT * FROM UserDataModel WHERE id = 4";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
			}
			reader.Close();

			return null;

		}

	
	}
}