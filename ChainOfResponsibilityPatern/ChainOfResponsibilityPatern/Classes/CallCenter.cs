using System.Collections.Generic;

namespace ChainOfResponsibilityPatern
{
	public class CallCenter
	{
		private List<Operator> _agents = new List<Operator>();

		public CallCenter()
		{
			var o1 = new Operator("Hakan");
			var o2 = new Operator("Ahmet");
			var o3 = new Operator("Mehmet");
			var o4 = new Operator("George");

			o1.State = false;
			o2.State = true; // Ahmet is avaliable
			o3.State = false;
			o4.State = false;

			o1.NextOperator = o2;
			o2.NextOperator = o3;
			o3.NextOperator = o4;
			o4.NextOperator = null;

			_agents.AddRange(new[] { o1, o2, o3, o4 });
		}

		public void TakeCall()
		{
			// Give the first agent task
			_agents[0].AnswerCall();
		}
	}
}
