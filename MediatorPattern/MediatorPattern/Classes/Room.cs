using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
	// Abstract Mediator
	public abstract class Room
	{
		protected List<Participant> _participants;

		protected Room()
		{
			_participants = new List<Participant>();
		}

		public void AddParticipant(Participant participant)
		{
			if (!_participants.Contains(participant))
			{
				_participants.Add(participant);
			}
		}

		public abstract void SendMessage(Participant sender, Participant receiver, string message);
		public abstract void SendBroadcastMessage(Participant sender, string message);
	}
}
