namespace ObserverPattern
{
	public interface IObservable
	{
		void Register(Control control);
		void Unregister(Control control);
		void Notify();
	}
}
