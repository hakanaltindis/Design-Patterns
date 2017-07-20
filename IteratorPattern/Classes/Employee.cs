namespace IteratorPattern
{
	public class Employee
	{
		private string Name;
		private string Title;

		public Employee(string name, string title)
		{
			Name = name;
			Title = title;
		}

		public override string ToString()
		{
			return $"{Name} {Title}";
		}
	}
}
