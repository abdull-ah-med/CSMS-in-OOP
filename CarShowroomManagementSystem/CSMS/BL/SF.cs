using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSMS.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSMS.BL
{
	class SF
	{
		public static bool usererroroutput(User u, bool flag, int num, int check)
		{
			if (check == 1 && u != null)
			{
				MessageBox.Show(u.Type + " Already Exists");
				return false;
			}
			if (check == 2 && u == null)
			{
				MessageBox.Show(u.Type + " Doesn't Exists");
				return false;

			}
			if (!flag)
			{
				MessageBox.Show("Invalid Input");
				return false;
			}
			if (!(num >= 8))
			{
				MessageBox.Show("Password Must Be Eight digits!");
				return false;
			}
			return true;
		}
		public static void wrongerror()
		{
			MessageBox.Show("Service / Task Failure! Please Try Again");
		}
		public static bool IsAlphabetic(string input)
		{
			return Regex.IsMatch(input, "^[a-zA-Z ]+$");
		}
	}
}
