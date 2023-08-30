using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.DL;
using CSMS.BL;
using System.IO;

namespace CSMS
{
	public partial class ShowUserBooking : Form
	{
		Customer cust;
		Booking b;
		string path = "Booking.txt";
		public ShowUserBooking(Customer c)
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			cust = c;
		}

		public void dataBind()
		{
			showuserbookings.DataSource = null;
			showuserbookings.DataSource = cust.CustomerBookings;
			showuserbookings.Columns["BookingCustomer"].Visible = false;
			showuserbookings.Columns["BookedCar"].Visible = false;
			showuserbookings.Refresh();
		}
		private void ShowUserBooking_Load(object sender, EventArgs e)
		{
			dataBind();
		}


		private void addbooking_Click(object sender, EventArgs e)
		{
			var f = new showcarselect();
			f.ShowDialog();
			Car car= f.c;
			if(car != null && car.Car_Available == true)
			{
				Booking b = new Booking(cust, car, "Booking Created By User");
				if(b != null)
				{
					BookingDL.addBooking(cust, b, path);
					MessageBox.Show("Booking Added By User Successfully!");
				}
			}
			else if(car != null && car.Car_Available == false)
			{
				MessageBox.Show("Your Desired Car is not Available At the Moment. Please Try Again");
			}
			dataBind();
		}

		private void reqbookingrm_Click(object sender, EventArgs e)
		{
			if (b != null && (MessageBox.Show("Do You Want to Cancel This Bookings?", "Delete Customer Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
			{
				BookingDL.updateBookingStatus(cust, b, "Booking Deletion Requested By Customer", path);
				MessageBox.Show("Booking Deletion has been Initiated! Visit Showroom For Futher Process");
			}
			else
			{
				MessageBox.Show("Booking Deletion Could not be Initiated! Please Try Again");
			}
		}

		private void showuserbookings_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				b = cust.CustomerBookings[e.RowIndex];
			}
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show("Some Error Has Occured, Please Try Again!");
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void showuserbookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if(e.RowIndex>= 0)
				b = cust.CustomerBookings[e.RowIndex];
			}
			catch (IndexOutOfRangeException ex)
			{
				MessageBox.Show("Some Error Has Occured, Please Try Again!");
			}
		}
	}
}
