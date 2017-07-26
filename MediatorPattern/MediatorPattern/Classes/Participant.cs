namespace MediatorPattern
{
	// Abstract Colleague
	public abstract class Participant
	{
		private string _nick;
		public string Nick
		{
			get { return _nick; }
			set { _nick = value; }
		}

		protected Participant(string nick)
		{
			this._nick = nick;
		}

		public abstract void ReceiveMessage(Participant sender, string message);
	}
}
