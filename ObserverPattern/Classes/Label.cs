namespace ObserverPattern
{
	public class Label : Control
	{
		public override void Add(IObservable observable)
		{
			observable.Register(this);
		}

		public override void Remove(IObservable observable)
		{
			observable.Unregister(this);
		}

		public override void OnAction(string val)
		{
			Text = val;
		}
	}
}
