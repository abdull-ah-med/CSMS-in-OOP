using CSMS.BL;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSMS.DL
{
	class UserDL
	{
		protected static List<User> users = new List<User>();
		public static List<User> Users
		{
			get { return users; }
			set { users = value; }
		}
		public static T GetUser<T>(string userId, string userPass) where T : User
		{
			var user = Users.FirstOrDefault(u => u.ID == userId && u.Pass == userPass && u is T);
			return (T)user;
		}
		public static T GetUser<T>(string userId) where T : User
		{
			var user = Users.FirstOrDefault(u => u.ID == userId && u is T);
			return (T)user;
		}
		public static bool DeleteUserFromList(User u)
		{
			return Users.Remove(u);
		}
		public static bool addUserToList(User user)
		{
			if (user != null)
			{
				Users.Add(user);
				return true;
			}
			return false;
		}
		public static void storeIntoFile(string path, User s)
		{
			StreamWriter f = new StreamWriter(path, true);
			f.WriteLine(s.Name + "," + s.ID + "," + s.Pass + "," + s.Contact + "," + s.Type);
			f.Flush();
			f.Close();
		}
		public static void updateFileData(string path)
		{
			StreamWriter f = new StreamWriter(path);
			foreach (User s in Users)
			{
				f.WriteLine(s.Name + "," + s.ID + "," + s.Pass + "," + s.Contact + "," + s.Type);
			}
			f.Flush();
			f.Close();
		}
		public static bool readFromFile(string path)
		{
			StreamReader f = new StreamReader(path);
			string record;
			if (File.Exists(path))
			{
				while ((record = f.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string name = splittedRecord[0];
					string id = splittedRecord[1];
					string pass = splittedRecord[2];
					string contact = splittedRecord[3];
					string type = splittedRecord[4];
					if (type == "Customer")
					{
						Customer c = new Customer(id, name, contact, pass, type);
						Users.Add(c);
					}
					else if (type == "Employee")
					{
						Employee e = new Employee(id, name, contact, pass, type);
						Users.Add(e);
					}
					else if (type == "Admin")
					{
						Admin a = new Admin(id, name, contact, pass, type);
						Users.Add(a);
					}
				}
				f.Close();
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
