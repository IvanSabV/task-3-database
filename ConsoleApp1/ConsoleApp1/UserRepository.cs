using System;

namespace UserRepository
{

	public class UserRepository
	{
		public int GetUserById(int userid)
		{
			string sql = "SELECT * FROM UserDataModel WHERE id = 1";
		}

		public int GetUserByName(int username)
		{
			string sql = "SELECT * FROM UserDataModel WHERE name = admin";
		}

		public int SearchUserByName(int query)
		{
			string sql = "SELECT * FROM UserDataModel WHERE name like 'ad%'";
		}

		public int AddUser(int userDataModel)
		{

		}

		public int UpdateUser(int userDataModel)
		{

		}

		public int UpdateUserState(int userId, int userState)
		{

		}
	}
}