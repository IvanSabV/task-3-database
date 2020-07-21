using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
	public class MessageRepository
	{
		public string GetUserMessages()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT content FROM MessageDataModel WHERE userid = 1";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString());
			}
			reader.Close();

			return null;
		}
		
		public string SearchUserMessages()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "SELECT content FROM MessageDataModel WHERE content like 'sme%' and userId = 6 ";

			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Console.WriteLine(reader[0].ToString());
			}
			reader.Close();

			return null;
		}

		public string AddMessage()
		{
			string connStr = "server=DESKTOP-VVD3IHK\\SQLEXPRESS;user=admin;database=UserContactMessage;password=123;";

			SqlConnection conn = new SqlConnection(connStr);

			conn.Open();

			string sql = "INSERT INTO messageDataModel VALUES(6, 80, '2020.10.10', '2020.10.11', 'smessages2')";
			
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