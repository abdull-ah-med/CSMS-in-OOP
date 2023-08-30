using CSMS.BL;
using CSMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
	public partial class UserInterface : Form
	{
		private string path = "Users.Txt";
		string bookingpath = "Booking.txt";
		int index;
		User u;
		public void dataBind()
		{
			employeeDataView.DataSource = null;
			employeeDataView.DataSource = UserDL.Users;
			employeeDataView.Refresh();
		}
		void clearData()
		{
			userid.Text = "";
			userpass.Text = "";
			username.Text = "";
			usercontact.Text = "";
			usertype.SelectedItem = null;
		}
		public UserInterface()
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
		}

		private void UserInterface_Load(object sender, EventArgs e)
		{
			employeeDataView.DataSource = UserDL.Users;
			Controls.Add(employeeDataView);
		}

		private void employeeDataView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			index = e.RowIndex;
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = employeeDataView.Rows[index];
				userid.Text = row.Cells[0].Value.ToString();
				username.Text = row.Cells[1].Value.ToString();
				usercontact.Text = row.Cells[2].Value.ToString();
				userpass.Text = row.Cells[3].Value.ToString();
				usertype.Text = row.Cells[4].Value.ToString();
				u = UserDL.Users[e.RowIndex];
			}
		}
		private void addUser_Click(object sender, EventArgs e)
		{
			User tuser = UserDL.GetUser<User>(userid.Text);
			if (SF.usererroroutput(tuser, SF.IsAlphabetic(username.Text), userpass.Text.Length, 1))
			{
				if (usertype.Text == "Admin")
				{
					Admin ad = new Admin(userid.Text, username.Text, usercontact.Text, userpass.Text,  usertype.Text);
					UserDL.addUserToList(ad);
					UserDL.storeIntoFile(path, ad);
					MessageBox.Show(usertype.Text + " added Successfully!");
					clearData();
					dataBind();
				}
				else if (usertype.Text == "Employee")
				{
					Employee emp = new Employee(userid.Text, username.Text, usercontact.Text, userpass.Text, usertype.Text);
					UserDL.addUserToList(emp);
					UserDL.storeIntoFile(path, emp);
					MessageBox.Show(usertype.Text + " added Successfully!");
					clearData();
					dataBind();
				}
			}

		}
		private void editUser_Click(object sender, EventArgs e)
		{
			int idx = UserDL.Users.IndexOf(u);
			if (SF.usererroroutput(u, SF.IsAlphabetic(username.Text), userpass.Text.Length, 2))
			{
				UserDL.Users[idx] = u;
				u.updateUser(userid.Text, userpass.Text, username.Text, usercontact.Text, usertype.Text);
				UserDL.updateFileData(path);
				MessageBox.Show(usertype.Text + " Data Updated Successfully!");
				clearData();
				dataBind();
			}
		}

		private void removeUser_Click(object sender, EventArgs e)
		{
			if (u != null && (MessageBox.Show("Do You Want to Delete This User?", "Delete  User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
			{
				if (UserDL.DeleteUserFromList(u))
				{
					if (u is Customer)
					{
						if (MessageBox.Show("Do You Want to Delete Customer Bookings too?", "Delete Customer Bookings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							BookingDL.removeBooking(u, bookingpath);
						}
					}
					UserDL.updateFileData(path);
					MessageBox.Show(usertype.Text + " Removed Successfully!", "User Removed");
					clearData();
					dataBind();
				}
				else
				{
					MessageBox.Show(usertype.Text + " Deletion Failed");
					clearData();
				}
			}
		}

		private void employeeDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
