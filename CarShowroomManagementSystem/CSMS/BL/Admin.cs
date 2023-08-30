using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMS.DL;

namespace CSMS.BL
{
	public class Admin : User
	{
		public Admin() : base() { }
		public Admin(string id, string name, string contact, string pass, string type) : base(id, name, contact, pass, type) { }
	}
}
