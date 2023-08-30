using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSMS.BL;

namespace CSMS.DL
{
	class CarDL
	{
		private static List<Car> _cars = new List<Car>();
		public static List<Car> Cars
		{
			get { return _cars; }
			set { _cars = value; }
		}
		public static Car DoesCarExist(string name, string color, string variant)
		{
			foreach (Car c in Cars)
			{
				if (c.CarName == name && c.CarColor == color && c.CarVariant == variant)
				{
					return c;
				}
			}
			return null;
		}
		public static bool RemoveCar(Car c)
		{
			if (c != null)
			{
				return Cars.Remove(c);
			}
			return false;
		}
		public static bool AddCarIntoList(Car car)
		{
			if (car != null)
			{
				Cars.Add(car);
				return true;
			}
			return false;
		}
		public static void storeCarDataIntoFile(string path, Car s)
		{
			StreamWriter f = new StreamWriter(path, true);
			f.WriteLine(s.CarName + "," + s.CarColor + "," + s.CarVariant + "," + s.CarPrice + "," + s.Filer_Tax + "," + s.NonFiler_Tax + "," + s.Car_Available);
			f.Flush();
			f.Close();
		}
		public static void updateCarData(string path)
		{
			StreamWriter f = new StreamWriter(path);
			foreach (Car s in Cars)
			{
				f.WriteLine(s.CarName + "," + s.CarColor + "," + s.CarVariant + "," + s.CarPrice + "," + s.Filer_Tax + "," + s.NonFiler_Tax + "," + s.Car_Available);
			}
			f.Flush();
			f.Close();
		}
		public static bool readCarDataFromFile(string path)
		{
			StreamReader f = new StreamReader(path);
			string record;
			if (File.Exists(path))
			{
				while ((record = f.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string carname = splittedRecord[0];
					string carcolor = splittedRecord[1];
					string carvariant = splittedRecord[2];
					double price = double.Parse(splittedRecord[3]);
					double ftax = double.Parse(splittedRecord[4]);
					double nftax = double.Parse(splittedRecord[5]);
					string cavail = splittedRecord[6];
					Car c = new Car(carname, carcolor, carvariant, price, ftax, nftax, cavail);
					Cars.Add(c);
				}
				f.Close();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
