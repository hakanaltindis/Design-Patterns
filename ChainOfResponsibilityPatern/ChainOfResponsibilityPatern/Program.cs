using System;

namespace ChainOfResponsibilityPatern
{
	class Program
	{
		static void Main(string[] args)
		{
			// Client dont regocnize the operators, the operators dont regocnize the client too
			Client.OpenCall(new CallCenter());

			Console.WriteLine();
			Console.WriteLine("Please press enter to exit...");
			Console.ReadLine();
		}
	}
}
