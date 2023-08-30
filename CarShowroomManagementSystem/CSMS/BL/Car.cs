using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSMS.BL
{
	public class Car
	{
		protected string carName;
		protected string carColor;
		protected string carVariant;
		protected double carPrice;
		protected double filer_Tax;
		protected double nonFiler_Tax;
		protected bool car_Available;
		public string CarName
		{
			get { return carName; }
			set { carName = value; }
		}
		public string CarColor
		{
			get { return carColor; }
			set { carColor = value; }
		}
		public string CarVariant
		{
			get { return carVariant; }
			set { carVariant = value; }
		}
		public double CarPrice
		{
			get { return carPrice; }
			set { carPrice = value; }
		}
		public double Filer_Tax
		{
			get { return filer_Tax; }
			set { filer_Tax = value; }
		}
		public double NonFiler_Tax
		{
			get { return nonFiler_Tax; }
			set { nonFiler_Tax = value; }
		}
		public bool Car_Available
		{
			get { return car_Available; }
			set { car_Available = value; }
		}
		public void setCarAvailability(string test)
		{
			if (test == "Yes" || test == "True" || test == "true")
			{
				Car_Available = true;
			}
			else
			{
				Car_Available = false;
			}
		}

		public Car(string carName, string carColor, string carVariant, double carPrice, double filerTaxpercentage, double nonfilerTaxPercentage, string iscavailable)
		{
			this.carName = carName;
			this.carColor = carColor;
			this.carVariant = carVariant;
			this.carPrice = carPrice;
			filer_Tax = filerTaxpercentage;
			nonFiler_Tax = nonfilerTaxPercentage;
			setCarAvailability(iscavailable);
		}
		public Car() { }
		public double CalculateFinalPrice(string isUserFiler)
		{
			if (isUserFiler == "Filer")
			{
				double finalPrice = carPrice + ((carPrice * filer_Tax) / 100);
				return finalPrice;
			}
			else
			{
				double finalPrice = carPrice + ((carPrice * nonFiler_Tax) / 100);
				return finalPrice;
			}
		}
		public bool AddCar(string name, string color, string variant, string price, string filer, string nonfiler, string iscavail)
		{
			if (!SF.IsAlphabetic(name) || !SF.IsAlphabetic(color))
			{
				return false;
			}
			if (!IsNumeric(price) || !IsNumeric(filer) || !IsNumeric(nonfiler))
			{
				return false;
			}
			carName = name;
			carColor = color;
			carVariant = variant;
			carPrice = int.Parse(price);
			filer_Tax = int.Parse(filer);
			nonFiler_Tax = int.Parse(nonfiler);
			setCarAvailability(iscavail);
			return true;
		}
		private bool IsNumeric(string input)
		{
			return Regex.IsMatch(input, "^[0-9]+$");
		}
	}
}
