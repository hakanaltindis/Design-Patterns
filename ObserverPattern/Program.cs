using System;

namespace ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Control c1 = new Label();
			c1.Name = "text1";

			Control c2 = new Label();
			c2.Name = "text2";

			Stock s = new Stock();
			s.Register(c1);
			s.Register(c2);

			s.Notify();
			Display(c1);
			Display(c2);

			s.GetElement();
			s.Notify();
			Display(c1);
			Display(c2);

			s.GetElement();
			s.Notify();
			Display(c1);
			Display(c2);

			Console.WriteLine();
			Console.WriteLine("Please press enter to exit!");
			Console.ReadLine();
		}

		public static void Display(Control control)
		{
			Console.WriteLine($"{control.Name} : {control.Text}");
		}
	}
}
