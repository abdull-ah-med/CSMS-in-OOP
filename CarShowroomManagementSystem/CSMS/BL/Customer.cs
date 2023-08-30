using CSMS.DL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.BL
{
	public class Customer : User
	{
		public Customer() : base() { }
		protected List<Booking> customerbookings = new List<Booking>();
		public Customer(string id, string name, string contact, string pass, string type) : base(id, name, contact, pass, type)
		{
		}
		public Customer(string id, string pass)
		{
			ID = id;
			Pass = pass;
			type = "Customer";
		}
		public List<Booking> CustomerBookings
		{
			get { return customerbookings; }
			set { customerbookings = value; }
		}
	}
}
