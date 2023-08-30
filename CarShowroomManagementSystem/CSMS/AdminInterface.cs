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

namespace CSMS
{
	public partial class AdminInterface : Form
	{
		Admin A;
		public AdminInterface(Admin c)
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			this.A = c;
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}


		private void Form2_Load_1(object sender, EventArgs e)
		{

		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			Form newf = new UserInterface();
			newf.ShowDialog();
		}

		private void carInterface_Click(object sender, EventArgs e)
		{
			Form nextform = new CarInterface();
			nextform.ShowDialog();
		}

		private void logout_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void profupdate_Click(object sender, EventArgs e)
		{
			Form f = new userprofupdate(A);
			f.ShowDialog();
		}

		private void bookinginter_Click(object sender, EventArgs e)
		{
			Form f = new AdminBookingInterface();
			f.ShowDialog();
		}
	}
}
