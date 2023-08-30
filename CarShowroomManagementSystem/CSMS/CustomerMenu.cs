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

namespace CSMS
{
	public partial class CustomerMenu : Form
	{
		Customer c;
		public CustomerMenu(Customer c)
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			this.c = c;
		}

		private void showAllCars_Click(object sender, EventArgs e)
		{
			Form newf = new ShowCar();
			newf.ShowDialog();
		}

		private void priceestimation_Click(object sender, EventArgs e)
		{
			Form fnew = new PriceEstimate();
			fnew.ShowDialog();
		}

		private void managebookings_Click(object sender, EventArgs e)
		{
			try
			{
				Form f = new ShowUserBooking(c);
				f.ShowDialog();
			}
			catch(IndexOutOfRangeException ex)
			{
				MessageBox.Show("Error Occured", "User Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void profupdate_Click(object sender, EventArgs e)
		{
			Form f = new userprofupdate(c); f.ShowDialog();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
