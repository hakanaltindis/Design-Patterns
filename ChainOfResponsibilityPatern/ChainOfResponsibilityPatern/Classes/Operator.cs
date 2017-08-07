using System;

namespace ChainOfResponsibilityPatern
{
	// Handler Object
	public class Operator
	{
		private bool _state;
		public bool State
		{
			get { return _state; }
			set { _state = value; }
		}

		private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private Operator _nextOperator;
		public Operator NextOperator
		{
			get { return _nextOperator; }
			set { _nextOperator = value; }
		}

		public Operator(string name)
		{
			_name = name;
		}

		public void AnswerCall()
		{
			if (_state)
			{
				//Answer
				Console.WriteLine($"{_name} answered the calling.");
			}
			else if (_nextOperator != null)
			{
				_nextOperator.AnswerCall();
			}
			else
			{
				Console.WriteLine("The calling is holding.");
			}
		}
	}
}
