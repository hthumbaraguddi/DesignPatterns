namespace _01BasicIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Elements elements = new Elements(new string[] {"Dog","Cat","Fish" });

            var iterator=elements.CreateIterator();

            for(string? item = iterator.First(); item != null; item = iterator.Next()) 
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

   


}