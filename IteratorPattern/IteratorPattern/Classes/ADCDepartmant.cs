using System.Collections.Generic;

namespace IteratorPattern
{
	public class ADCDepartmant : IIterable
	{
		private List<Employee> Employees;

		public ADCDepartmant()
		{
			Employees = new List<Employee>
			{
				new Employee("Hakan Test1", "Manager"),
				new Employee("Hakan Test2", "Coder"),
				new Employee("Hakan Test3", "Software Engineer")
			};
		}

		public List<Employee> GetEmployees()
		{
			return Employees;
		}

		public IIterator GetIterator()
		{
			return new ListIterator();
		}
	}
}
