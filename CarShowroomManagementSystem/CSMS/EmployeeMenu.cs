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
using System.Runtime.InteropServices;

namespace CSMS
{
	public partial class EmployeeMenu : Form
	{
		Employee P;
		public EmployeeMenu(Employee p)
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			P = p;
		}


		private void viewCars_Click(object sender, EventArgs e)
		{
			Form form = new ShowCar();
			form.ShowDialog();
		}

		private void getPrice_Click(object sender, EventArgs e)
		{
			Form fnew = new PriceEstimate();
			fnew.ShowDialog();
		}

		private void managebookings_Click(object sender, EventArgs e)
		{
			Form f = new EmpBookingMangement();
			f.ShowDialog();
		}

		private void updateprof_Click(object sender, EventArgs e)
		{
			Form newf = new userprofupdate(P);
			newf.ShowDialog();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void EmployeeMenu_Load(object sender, EventArgs e)
		{

		}
	}
}
