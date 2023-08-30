using CSMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.BL;
using System.IO;

namespace CSMS
{
	public partial class EmpBookingMangement : Form
	{
		Booking b;
		string bookingpath = "Booking.txt";
		public EmpBookingMangement()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			empviewbooking.DataSource = BookingDL.Bookings;
			empviewbooking.Columns["BookingCustomer"].Visible = false;
			empviewbooking.Columns["BookedCar"].Visible = false;
		}
		public void dataBind()
		{
			empviewbooking.DataSource = null;
			empviewbooking.DataSource = BookingDL.Bookings;
			empviewbooking.Refresh();
		}
		private void empviewbooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				b = BookingDL.Bookings[e.RowIndex];
			}
		}
		private void empviewbooking_Load(object sender, EventArgs e)
		{
			empviewbooking.DataSource = BookingDL.Bookings;
		}
		private void updatebooking_Click(object sender, EventArgs e)
		{
			if (b != null)
			{
				BookingDL.updateBookingStatus(b, "Booking Confirmed by Employee!", bookingpath);
				MessageBox.Show("Booking Status Has Been Successfully Updated!");
				BookingDL.updateBookingsFileData(bookingpath);
				dataBind();
			}
			else
			{
				SF.wrongerror();
			}
		}

		private void rmbooking_Click(object sender, EventArgs e)
		{
			if (b != null)
			{
				BookingDL.updateBookingStatus(b, "Booking Deletion Verified by Employee", bookingpath);
				MessageBox.Show("Booking Deletion Verified By Employee");
				BookingDL.updateBookingsFileData(bookingpath);
				dataBind();
			}
			else
			{
				SF.wrongerror();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void empviewbooking_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				b = BookingDL.Bookings[e.RowIndex];
			}
		}
	}
}
