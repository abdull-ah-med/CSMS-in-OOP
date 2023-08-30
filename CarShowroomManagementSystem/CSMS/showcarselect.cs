using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.BL;
using CSMS.DL;

namespace CSMS
{
	public partial class showcarselect : Form
	{
		public Car c;

		public showcarselect()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			showcars.DataSource = CarDL.Cars;
		}
		private void returnselectcar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void showcars_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				c = CarDL.Cars[e.RowIndex];
			}
		}
	}
}
