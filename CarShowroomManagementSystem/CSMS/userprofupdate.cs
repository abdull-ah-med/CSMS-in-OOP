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
	public partial class userprofupdate : Form
	{
		User u;
		string path = "Users.Txt";
		public userprofupdate(User u)
		{
			this.MinimumSize = new Size(1300, 750);
			this.MinimumSize = new Size(1300, 750);
			InitializeComponent();
			this.u = u;
		}

		private void userprofupdate_Load(object sender, EventArgs e)
		{
			name.Text = u.Name;
			id.Text = u.ID ;
			pass.Text = u.Pass;
			contact.Text = u.Contact;
		}
		private void ClearData()
		{
			name.Text = "";
			id.Text = "";
			pass.Text = "";
			contact.Text = "";
		}
		private void updateprof_Click(object sender, EventArgs e)
		{
			User testuser = UserDL.GetUser<User>(id.Text);
			if(testuser != null && testuser != u && !(SF.IsAlphabetic(name.Text)))
			{
				MessageBox.Show("Failed to Update!");
			}
			else if(!(SF.IsAlphabetic(name.Text)))
			{
				MessageBox.Show("Name Can Contain Only Alphabets!");
			}
			else
			{
				int idx = UserDL.Users.IndexOf(u);
				string a = u.Type;
				u.updateUser(id.Text, name.Text, contact.Text, pass.Text, a);
				UserDL.Users[idx] = u;
				UserDL.updateFileData(path);
				MessageBox.Show("User Has Been Updated!");
				ClearData();
			}
		}

		private void back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
