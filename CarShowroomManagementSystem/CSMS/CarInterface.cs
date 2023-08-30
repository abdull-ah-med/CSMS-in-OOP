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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSMS
{
	public partial class CarInterface : Form
	{
		int index = 0;
		Car c;
		string path = "Cars.Txt";
		string bookingpath = "Booking.txt";
		public CarInterface()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
		}
		public void dataBind()
		{
			carData.DataSource = null;
			carData.DataSource = CarDL.Cars;
			carData.Refresh();
		}
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form5_Load(object sender, EventArgs e)
		{
			carData.DataSource = CarDL.Cars;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void ClearDataFromForm()
		{
			carname.Text = "";
			carvariant.Text = "";
			carprice.Text = "";
			filertax.Text = "";
			nonfilertax.Text = "";
			carcolor.Text = "";
			iscaravailable.SelectedItem = null;
		}
		private void addCar_Click(object sender, EventArgs e)
		{
			Car tcar = CarDL.DoesCarExist(carname.Text, carcolor.Text, carvariant.Text);
			if (tcar == null)
			{
				Car testcar = new Car();
				bool test = testcar.AddCar(carname.Text, carcolor.Text, carvariant.Text, carprice.Text, filertax.Text, nonfilertax.Text, iscaravailable.Text);
				if (test)
				{
					CarDL.AddCarIntoList(testcar);
					CarDL.storeCarDataIntoFile(path, testcar);
					MessageBox.Show("Car Addition Successfull");
					ClearDataFromForm();
					dataBind();
				}
				else
				{
					MessageBox.Show("Car Addition Failure");
					ClearDataFromForm();
				}
			}
			else
			{
				MessageBox.Show("Car Already Exists");
				ClearDataFromForm();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void carData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void carData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void carData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			index = e.RowIndex;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = carData.Rows[index];
				carname.Text = row.Cells[0].Value.ToString();
				carcolor.Text = row.Cells[1].Value.ToString();
				carvariant.Text = row.Cells[2].Value.ToString();
				carprice.Text = row.Cells[3].Value.ToString();
				filertax.Text = row.Cells[4].Value.ToString();
				nonfilertax.Text = row.Cells[5].Value.ToString();
				iscaravailable.Text = row.Cells[6].Value.ToString();
				c = CarDL.Cars[e.RowIndex];
			}
		}
		private void editCar_Click(object sender, EventArgs e)
		{
			if (c != null)
			{
				Car previous = c;
				int idx = CarDL.Cars.IndexOf(c);
				bool test = c.AddCar(carname.Text, carcolor.Text, carvariant.Text, carprice.Text, filertax.Text, nonfilertax.Text, iscaravailable.Text);
				if (test)
				{
					CarDL.Cars[idx] = c;
					CarDL.updateCarData(path);
					BookingDL.updateCarInBooking(previous, c, bookingpath);
					MessageBox.Show("Car Edit Successfull");
					ClearDataFromForm();
					dataBind();
				}
				else
				{
					MessageBox.Show("Car Edit Failure");
					ClearDataFromForm();
				}
			}
			else
			{
				MessageBox.Show("Car Does Not Exists");
				ClearDataFromForm();
			}
		}

		private void rmCar_Click(object sender, EventArgs e)
		{
			Car testcar = CarDL.DoesCarExist(carname.Text, carcolor.Text, carvariant.Text);
			if (testcar != null && (MessageBox.Show("Do You Want to Delete " + testcar.CarName + " ?", "Delete  " + testcar.CarName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
			{
				bool test = CarDL.RemoveCar(testcar);
				if (test)
				{
					CarDL.updateCarData(path);
					BookingDL.removeBooking(testcar, bookingpath);
					MessageBox.Show("Car Removal Successfull!");
					ClearDataFromForm();
					dataBind();
				}
				else
				{
					MessageBox.Show("Car Deletion Failure");
					ClearDataFromForm();
				}
			}
			else if(testcar == null)
			{
				MessageBox.Show("Car Does Not Exists");
				ClearDataFromForm();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void iscaravailable_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
