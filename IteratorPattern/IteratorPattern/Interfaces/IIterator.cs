namespace IteratorPattern
{
	public interface IIterator
	{
		bool Next();
		object GetItem();
	}
}
