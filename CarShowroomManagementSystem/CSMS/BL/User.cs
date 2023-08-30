using CSMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSMS.BL
{
	public class User
	{
		protected string id;
		protected string name;
		protected string contact;
		protected string pass;
		protected string type;
		public string ID
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Contact
		{
			get { return contact; }
			set { contact = value; }
		}
		public string Pass
		{
			get { return pass; }
			set { pass = value; }
		}
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public User()
		{
			id = "";
			name = "";
			contact = "";
			pass = "";
		}
		public User(string id, string name, string contact, string pass, string type)
		{
			this.id = id;
			this.name = name;
			this.contact = contact;
			this.pass = pass;
			this.type = type;
		}
		public void updateUser(string id, string name, string contact, string pass, string type)
		{
			this.id = id;
			this.name = name;
			this.contact = contact;
			this.pass = pass;
			this.type = type;
		}
	}
}
