namespace IteratorPattern
{
	public class ListIterator : IIterator
	{
		private ADCDepartmant adc = new ADCDepartmant();
		private int index = 0;

		public object GetItem()
		{
			var e = adc.GetEmployees()[index];
			index++;
			return e;
		}

		public bool Next()
		{
			return index < adc.GetEmployees().Count;
		}
	}
}
