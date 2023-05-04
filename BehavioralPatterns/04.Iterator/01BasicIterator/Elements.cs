namespace _01BasicIterator
{
    public interface IElementsCollection
    {
        IElementsIterator CreateIterator();
    }

    public class Elements : IElementsCollection
    {
        public string[] allItems;

        public Elements(string[] Items)
        {
            this.allItems = Items;   
        }
        public IElementsIterator CreateIterator()
        {
            return new ElementIterator(allItems);
        }
    }
}