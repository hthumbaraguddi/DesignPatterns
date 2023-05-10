namespace VendingMachineEventHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            SnacksVM svm = new SnacksVM();

            CentralStockMonitoringSystem centralStockMonitoringSystem = new CentralStockMonitoringSystem();
            svm.Notifier += centralStockMonitoringSystem.ReceiveStockChangeNotification;

            SnackStockSupplier supplier = new SnackStockSupplier();
            svm.Notifier += supplier.ReceiveStockChangeNotification;


            ////lets buy something from Vending machin
            svm.InitiateSale("Butter-2", 6);
            svm.InitiateSale("Milk", 96);

            Console.ReadKey();


        }
    }
}