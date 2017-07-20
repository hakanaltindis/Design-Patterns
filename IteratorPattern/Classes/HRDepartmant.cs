namespace IteratorPattern
{
	public class HRDepartmant : IIterable
	{
		private Employee[] Employees;

		public HRDepartmant()
		{
			Employees = new Employee[3]
			{
				new Employee("Hakan Test4", "Manager"),
				new Employee("Hakan Test5", "Coder"),
				new Employee("Hakan Test6", "Software Engineer")
			};
		}

		public Employee[] GetEmployees()
		{
			return Employees;
		}

		public IIterator GetIterator()
		{
			return new ArrayIterator();
		}
	}
}
