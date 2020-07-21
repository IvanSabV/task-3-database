using System;

public class ContactRepository
{
	public int GetUserContact(int userid, int contactid)
	{
		string sql = "SELECT * FROM ContactDataModel WHERE id = 1";
	}

	public int GetUserContacts(int userId)
	{
		string sql = "SELECT * FROM ContactDataModel WHERE name = admin";
	}

	public int SearchUserContacts(int userId, int query)
	{
		string sql = "SELECT * FROM ContactDataModel WHERE name like 'ad%'";
	}

	public int AddContact(int contactDataModel)
	{

	}

	public int UpdateContact(int contactDataModel)
	{

	}

	public int DeleteContact(int userId, int userStcontactIdate)
	{

	}
}
