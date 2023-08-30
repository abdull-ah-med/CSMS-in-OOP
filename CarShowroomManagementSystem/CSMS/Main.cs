using CSMS.BL;
using CSMS.DL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSMS
{
	public partial class Main : Form
	{
		string path = "Users.Txt";
		string carpath = "Cars.Txt";
		string bookingpath = "Booking.txt";
		public Main()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			if(UserDL.readFromFile(path) && CarDL.readCarDataFromFile(carpath) && BookingDL.readBookingsFromFile(bookingpath))
			{
				MessageBox.Show("Data Load Successfull!");
			}
		}

		private void ClearDataFromForm()
		{
			id.Text = "";
			pass.Text = "";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string id = this.id.Text;
			string pass = this.pass.Text;
			var user = UserDL.GetUser<User>(id, pass);
			if (user != null)
			{
				if (user is Admin admin)
				{
					Form f = new AdminInterface(admin);
					f.ShowDialog();
				}
				else if (user is Employee employee)
				{
					Form f = new EmployeeMenu(employee);
					f.ShowDialog();
				}
				else if (user is Customer customer)
				{
					Form f = new CustomerMenu(customer);
					f.ShowDialog();
				}
				ClearDataFromForm();
			}
			else
			{
				MessageBox.Show("User is Invalid");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string id = this.id.Text;
			string pass = this.pass.Text;
			if (UserDL.GetUser<User>(id) == null && this.id.Text != "" && this.pass.Text != "")
			{
				Customer c = new Customer(id, pass);
				UserDL.addUserToList(c);
				UserDL.storeIntoFile(path, c);
				MessageBox.Show("User is Created");
			}
			else
			{
				MessageBox.Show("User is Invalid");
			}
		}

	}
}
