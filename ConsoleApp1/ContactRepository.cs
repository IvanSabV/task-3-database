using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
	public class ContactRepository
	{
		public string GetUserContact()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT userid, contactid FROM ContactDataModel WHERE userid = 2";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
			}
			reader.Close();

			return null;
		}
		
		public string GetUserContacts()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT * FROM ContactDataModel WHERE userid = 3";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
			}
			reader.Close();

			return null;
		}

		public string SearchUserContacts()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT * frFROMom ContactDataModel a INNER JOIN UserDataModel b on a.id = b.user_id where b.name = $name";
			
			SqlCommand command = new SqlCommand(sql, conn);

			return null;
		}

		public string AddContact()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "INSERT INTO ContactDataModel VALUES(4, 40, '2010-10-10')";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString());
			}
			reader.Close();

			return null;
		}

		public string UpdateContact()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "UPDATE ContactDataModel SET contactid = '200' WHERE userid = 2";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString());
			}
			reader.Close();

			return null;
		}

		public string DeleteContact()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "DELETE FROM ContactDataModel WHERE contactid = '25'";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString());
			}
			reader.Close();

			return null;
		}

		
	}
}