using System;

namespace MediatorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var p1 = new NormalParticipant("Hakan");
			var p2 = new NormalParticipant("Ahmet");
			var p3 = new NormalParticipant("Kerem");
			var p4 = new NormalParticipant("Zeren");
			var p5 = new ModeratorParticipant("Admin");

			var softwareRoom = new SoftwareRoom();
			softwareRoom.AddParticipant(p1);
			softwareRoom.AddParticipant(p2);
			softwareRoom.AddParticipant(p3);
			softwareRoom.AddParticipant(p4);
			softwareRoom.AddParticipant(p5);

			softwareRoom.SendBroadcastMessage(p5, "Hi, Everybody");

			softwareRoom.SendMessage(p1, p3, "When will the android courses begin?");

			softwareRoom.SendMessage(p3, p1, "It will start at October.");

			Console.WriteLine();
			Console.WriteLine("Please press enter to exit!");
			Console.ReadLine();
		}
	}
}
