namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            SnacksVM  svm = new SnacksVM();

            CentralStockMonitoringSystem centralStockMonitoringSystem = new CentralStockMonitoringSystem();
            SnackStockSupplier supplier= new SnackStockSupplier();

            svm.AddObserver(centralStockMonitoringSystem);
            svm.AddObserver(supplier);

            //lets buy something from Vending machin
            svm.InitiateSale("Butter-2", 6);
            svm.InitiateSale("Milk", 96);
            
            Console.ReadKey();


        }
    }

}