using System;

public class MessageRepository
{
	public int GetUserMessages(int userid)
	{
		string sql = "SELECT * FROM MessageDataModel WHERE id = 1";
	}

	public int SearchUserMessages(int userId, int contactid, int query)
	{
		string sql = "SELECT * FROM MessageDataModel WHERE name = admin";
	}

	public int AddMessage(int messageDataModel)
	{
		string sql = "SELECT * FROM MessageDataModel WHERE name like 'ad%'";
	}

}
