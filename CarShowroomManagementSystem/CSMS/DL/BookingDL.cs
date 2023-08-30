using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CSMS.BL;

namespace CSMS.DL
{
	class BookingDL
	{
		protected static List<Booking> _bookings = new List<Booking>();
		public static List<Booking> Bookings
		{
			get { return _bookings; }
			set { _bookings = value; }
		}
		public static Booking FindBooking(string bookingid)
		{
			foreach (Booking b in Bookings)
			{
				if (b.BookingID == bookingid)
				{
					return b;
				}
			}
			return null;
		}
		public static void addBookingtoList(Booking booking)
		{
			Bookings.Add(booking);
		}
		public static void storeBookingsIntoFile(string path, Booking s)
		{
			StreamWriter f = new StreamWriter(path, true);
			f.WriteLine(s.BookingCustomer.ID + "," + s.BookedCarName + "," + s.BookedCarColor + "," + s.BookedCarVariant + "," + s.BookingStatus + "," + s.BookingID);
			f.Flush();
			f.Close();
		}
		public static void updateBookingsFileData(string path)
		{
			StreamWriter f = new StreamWriter(path);
			foreach (Booking s in Bookings)
			{
				f.WriteLine(s.BookingCustomer.ID + "," + s.BookedCarName + "," + s.BookedCarColor + "," + s.BookedCarVariant + "," + s.BookingStatus + "," + s.BookingID);
			}
			f.Flush();
			f.Close();
		}
		public static bool readBookingsFromFile(string path)
		{
			bool flag;
			StreamReader f = new StreamReader(path);
			string record;
			if (File.Exists(path))
			{
				while ((record = f.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string custid = splittedRecord[0];
					string carname = splittedRecord[1];
					string carcolor = splittedRecord[2];
					string carv = splittedRecord[3];
					string bstatus = splittedRecord[4];
					string bid = splittedRecord[5];
					Booking b = new Booking();
					b.BookingStatus = bstatus;
					b.BookingID = bid;
					b.setCustomer(custid);
					b.setBookingCar(carname, carcolor, carv);
					Bookings.Add(b);
				}
				f.Close();
				setCustomerBookings();
				flag = true;
			}
			else
			{
				flag = false;
			}
			setCustomerBookings();
			return flag;
		}
		public static void setCustomerBookings()
		{
			foreach (Customer C in UserDL.Users.OfType<Customer>())
			{
				setCustomerBookings(C);
			}
		}
		public static void setCustomerBookings(Customer C)
		{
			C.CustomerBookings.Clear();
			foreach (Booking B in Bookings)
			{
				if (B.BookingCustomer == C)
				{
					C.CustomerBookings.Add(B);
				}
			}
		}
		public static void updateBookingStatus(Booking b, string status, string path)
		{
			int idx = Bookings.IndexOf(b);
			foreach (Customer c in UserDL.Users.OfType<Customer>())
			{
				if (b.BookingCustomer == c)
				{
					int id = c.CustomerBookings.IndexOf(b);
					b.BookingStatus = status;
					c.CustomerBookings[id] = b;
					break;
				}
			}
			Bookings[idx] = b;
			updateBookingsFileData(path);
		}
		public static void updateBookingStatus(Customer c, Booking b, string status, string path)
		{
			int idx = Bookings.IndexOf(b);
			c.CustomerBookings.Remove(b);
			b.BookingStatus = status;
			Bookings[idx] = b;
			updateBookingsFileData(path);
		}
		public static void updateCarInBooking(Car previous, Car next, string path)
		{
			foreach (Booking B in Bookings)
			{
				if (B.BookedCar == previous)
				{
					B.BookedCar = next;
				}
			}
			updateBookingsFileData(path);
		}
		public static void removeBooking(Booking b, string path)
		{
			Bookings.Remove(b);
			foreach (Customer C in UserDL.Users.OfType<Customer>())
			{
				if (b.BookingCustomer == C)
				{
					C.CustomerBookings.Remove(b);
				}
			}
			updateBookingsFileData(path);
		}
		public static void removeBooking(Car c, string path)
		{
			if (c != null)
			{
				foreach (Booking B in Bookings.ToList())
				{
					if (B.BookedCar == c)
					{
						removeBooking(B, path);
					}
				}
			}
		}
		public static void removeBooking(User c, string path)
		{
			foreach (Booking B in Bookings.ToList())
			{
				if (c != null && B.BookingCustomer == c)
				{
					Bookings.Remove(B);
				}
			}
			updateBookingsFileData(path);
		}
		public static void addBooking(Customer c, Booking B, string path)
		{
			if (B != null)
			{
				Bookings.Add(B);
				c.CustomerBookings.Add(B);
				storeBookingsIntoFile(path, B);
			}
		}
	}
}
