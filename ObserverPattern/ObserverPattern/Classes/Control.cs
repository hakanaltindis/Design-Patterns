namespace ObserverPattern
{
	public abstract class Control
	{
		protected string _text;
		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

		protected string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}



		// Run the method when state changed
		public abstract void OnAction(string val);

		// Binding & Unbinding
		public abstract void Add(IObservable observable);
		public abstract void Remove(IObservable observable);

	}
}
