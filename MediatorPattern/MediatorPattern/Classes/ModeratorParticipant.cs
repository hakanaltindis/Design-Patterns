using System;

namespace MediatorPattern
{
	// Concrete Colleague - 2
	public class ModeratorParticipant : Participant
	{
		public ModeratorParticipant(string nick) : base(nick)
		{

		}

		public override void ReceiveMessage(Participant sender, string message)
		{
			Console.WriteLine($"{sender.Nick} -> {this.Nick} : {message}");
		}
	}
}
