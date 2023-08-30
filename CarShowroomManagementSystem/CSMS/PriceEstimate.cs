using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMS.BL;
using CSMS.DL;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Linq;

namespace CSMS
{
	public partial class PriceEstimate : Form
	{
		Car selectCar;
		public PriceEstimate()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			viewCar.DataSource = CarDL.Cars;
		}
		public void dataBind()
		{
			viewCar.DataSource = null;
			viewCar.DataSource = CarDL.Cars;
			viewCar.Refresh();
		}
		private void viewbooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				selectCar = CarDL.Cars[e.RowIndex];
			}
		}
		private void viewbooking_Load(object sender, EventArgs e)
		{
			viewCar.DataSource = CarDL.Cars;
		}
		private void pestimate_Click(object sender, EventArgs e)
		{
			if(selectCar != null)
			{
				double price = selectCar.CalculateFinalPrice(filerstatus.Text);
				MessageBox.Show("Car Estimated Price For the Selected Car is( " + filerstatus.Text + " ): PKR " + price + "/-");
				filerstatus.SelectedItem = null;
			}
			else
			{
				MessageBox.Show("Failed! Please Try Again!");
			}
		}
		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void viewCar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				selectCar = CarDL.Cars[e.RowIndex];
			}
		}
	}
}
