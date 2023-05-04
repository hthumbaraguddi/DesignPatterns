using System.Collections;

namespace _01BasicIterator
{

    public interface IElementsIterator
    {
        string? First();
        string? Next();

        string? Previous { get; }
        bool ReachedEnd { get; }
        string CurrentItem { get; }
    }

    public class ElementIterator : IElementsIterator, IEnumerable<string>
    {
        public string[] Elements { get; private set; }

        public int currentItemPosition = 0;

        public ElementIterator(string[] collection) {this.Elements = collection;}

        public bool ReachedEnd
        {
            get{return currentItemPosition == Elements.Length;}
        }

        public string CurrentItem { get; private set; }

        public string PreviousItem { get; private set; }
        

        public string? First()
        {
            return this.FirstOrDefault() !=null ? this.FirstOrDefault() : string.Empty; ;
        }

        public string? Next()
        {
            if(this.GetEnumerator().MoveNext())
            {
                PreviousItem = CurrentItem;
                currentItemPosition++;
                if (!ReachedEnd)
                {
                    CurrentItem =this.Elements[currentItemPosition];
                    return CurrentItem;
                }
            }
            return null;            
        }

        public string? Previous
        {
            get { return PreviousItem; }
        }

        public IEnumerator<string> GetEnumerator()
        {            
            var it = this.Elements.Cast<string>().GetEnumerator();
            return it;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}