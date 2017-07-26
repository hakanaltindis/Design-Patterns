using System;

namespace IteratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var hr = new HRDepartmant();
			var itr = hr.GetIterator();

			while (itr.Next())
			{
				Console.WriteLine(itr.GetItem().ToString());
			}

			var adc = new ADCDepartmant();
			var itr2 = adc.GetIterator();

			while (itr2.Next())
			{
				Console.WriteLine(itr2.GetItem().ToString());
			}

			Console.WriteLine();
			Console.WriteLine("Please press Enter to exit!");
			Console.ReadLine();
		}
	}


}
