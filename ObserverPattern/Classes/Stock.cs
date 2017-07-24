using System.Collections.Generic;

namespace ObserverPattern
{
	public class Stock : IObservable
	{
		private int _number;
		private List<Control> controls;

		public Stock()
		{
			controls = new List<Control>();
			_number = 10;
		}

		public void GetElement()
		{
			_number--;
		}

		public void Notify()
		{
			for (int i = 0; i < controls.Count; i++)
			{
				controls[i].OnAction(_number.ToString());
			}
		}

		public void Register(Control control)
		{
			controls.Add(control);
		}

		public void Unregister(Control control)
		{
			controls.Remove(control);
		}
	}
}
