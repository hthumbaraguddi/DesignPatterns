namespace RetailBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(500);

            account.Deposite(100);
            account.WithDraw(601);
            account.Deposite(100);
            Console.ReadLine();
        }
    }
}