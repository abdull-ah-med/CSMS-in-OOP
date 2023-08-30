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

namespace CSMS
{
	public partial class ShowCar : Form
	{
		public ShowCar()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			viewcar.DataSource = CarDL.Cars;
		}
		private void viewcar_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void viewcar_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ShowCar_Load(object sender, EventArgs e)
		{

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
