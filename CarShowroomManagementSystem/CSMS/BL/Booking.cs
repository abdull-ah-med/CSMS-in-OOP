using CSMS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.BL
{
	public class Booking
	{
		int booking = BookingDL.Bookings.Count;
		protected Car bookedCar;
		protected string bookingID;
		protected Customer bookingCustomer;
		protected string bookingStatus;
		public Booking(Customer customer, Car car, string status)
		{
			bookingCustomer = customer;
			bookedCar = car;
			bookingStatus = status;
			bookingID = "B - " + booking;
		}
		public Booking()
		{

		}
		public void setCustomer(string id)
		{
			Customer c = UserDL.GetUser<Customer>(id);
			if(c != null)
			{
				bookingCustomer = c;
			}
		}
		public void setBookingCar(string carname, string carcolor, string carvariant)
		{
			Car c = CarDL.DoesCarExist(carname, carcolor, carvariant);
			if(c != null)
			{
				bookedCar = c;
			}
		}
		public string CustomerName
		{
			get { return BookingCustomer.Name; }
			set { BookingCustomer.Name = value;}
		}
		public string BookedCarName
		{
			get { return BookedCar.CarName; }
			set { BookedCar.CarName = value;}
		}
		public string BookedCarColor
		{
			get { return BookedCar.CarColor; }
			set { BookedCar.CarColor = value; }
		}
		public string BookedCarVariant
		{
			get { return BookedCar.CarVariant; }
			set { BookedCar.CarVariant = value; }
		}
		public string BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}
		public string BookingStatus
		{
			get { return bookingStatus; }
			set { bookingStatus = value; }
		}
		public Customer BookingCustomer
		{
			get { return bookingCustomer; }
			set { bookingCustomer = value; }
		}
		public Car BookedCar
		{
			get { return bookedCar; }
			set { bookedCar = value; }
		}
	}
}
