using System;

namespace MediatorPattern
{
	// Concrete Colleague
	public class NormalParticipant : Participant
	{
		public NormalParticipant(string nick) : base(nick)
		{

		}

		public override void ReceiveMessage(Participant sender, string message)
		{
			Console.WriteLine($"{sender.Nick} -> {this.Nick} : {message}");
		}
	}
}
