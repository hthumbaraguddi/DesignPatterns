namespace RomanCalculator
{
    //more info at https://www.dofactory.com/net/interpreter-design-pattern
    internal class Program
    {
        static void Main(string[] args)
        {

            RomanParser client = new RomanParser();

            Console.WriteLine($"Value of IX in Numberics is: {client.ConvertRomanToNumeric("IX")}");

            Console.WriteLine(client.ConvertNumbericToRoman(6));

            Console.ReadKey();
        }
    }
}
