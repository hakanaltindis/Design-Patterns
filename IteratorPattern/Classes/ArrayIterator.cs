namespace IteratorPattern
{
	public class ArrayIterator : IIterator
	{
		private HRDepartmant hr = new HRDepartmant();
		private int index = 0;

		public object GetItem()
		{
			var e = hr.GetEmployees()[index];
			index++;
			return e;
		}

		public bool Next()
		{
			return index < hr.GetEmployees().Length;
		}
	}
}
