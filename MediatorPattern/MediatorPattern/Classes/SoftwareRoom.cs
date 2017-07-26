namespace MediatorPattern
{
	// Concrete Mediator
	public sealed class SoftwareRoom : Room
	{
		public override void SendBroadcastMessage(Participant sender, string message)
		{
			foreach (var participant in _participants)
			{
				participant.ReceiveMessage(sender, message);
			}
		}

		public override void SendMessage(Participant sender, Participant reciever, string message)
		{
			reciever.ReceiveMessage(sender, message);
		}
	}
}
