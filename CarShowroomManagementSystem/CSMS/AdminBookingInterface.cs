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
using CSMS.DL;

namespace CSMS
{
	public partial class AdminBookingInterface : Form
	{
		Booking b;
		string path = "Booking.txt";
		public AdminBookingInterface()
		{
			InitializeComponent();
			custbooking.DataSource = BookingDL.Bookings;
			custbooking.Columns["BookingCustomer"].Visible = false;
			custbooking.Columns["BookedCar"].Visible = false;
		}
		public void dataBind()
		{
			custbooking.DataSource = null;
			custbooking.DataSource = BookingDL.Bookings;
			custbooking.Columns["BookingCustomer"].Visible = false;
			custbooking.Columns["BookedCar"].Visible = false;
			custbooking.Refresh();
		}

		private void updatebooking_Click(object sender, EventArgs e)
		{
			if(b != null)
			{
				BookingDL.updateBookingStatus(b, bookingstatus.Text, path);
				MessageBox.Show("Booking Has Been Successfully Updated!");
				dataBind();
				bookingstatus.Text = "";
			}
		}

		private void rmbooking_Click(object sender, EventArgs e)
		{
			if(b != null && (MessageBox.Show("Do You Want to Delete this Booking?", "Delete Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
			{
				BookingDL.removeBooking(b, path);
				BookingDL.updateBookingsFileData(path);
				MessageBox.Show("Booking Has Been Deleted Successfully!");
				dataBind();
				bookingstatus.Text = "";
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void custbooking_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)
			{
				b = BookingDL.Bookings[e.RowIndex];
			}
		}

		private void custbooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
