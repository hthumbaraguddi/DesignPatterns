using System.Runtime.CompilerServices;

namespace VendingMachineEventHandler
{  

    public class StockChangeEvent : EventArgs
    {
        public int QuantityToOrder { get; private set; }
        public int QuantityLeft { get; private set; }
        public string Itemname { get; private set; }

        public string SnacksVendingMachineID { get; private set; }

        public StockChangeEvent(string id, string itemName, int qLeft, int qOrder)
        {
            this.SnacksVendingMachineID = id; this.Itemname = itemName; this.QuantityLeft = qLeft; this.QuantityToOrder = qOrder;
        }
    }

    public interface IStocksListener
    {
      void ReceiveStockChangeNotification(object? obj, StockChangeEvent notification);
    }
    public abstract class StockChangeNotifier
    {
        public Dictionary<string, int> Stocks { get; set; }
        public List<IStocksListener>? StocksListeners { get; protected set; }

        public EventHandler<StockChangeEvent>? Notifier { get; set; }

        public string ID { get; protected set; }

    }
    public class SnacksVM : StockChangeNotifier
    {
        public SnacksVM()
        {
            this.ID = "SVM-123";            

            this.StocksListeners = new List<IStocksListener>();
            this.Stocks = new Dictionary<string, int>()
                {
                    { "Milk", 100 },
                    { "Egg-1", 100 },
                    { "Egg-2", 100 },
                    { "Butter-1", 20 },
                    { "Butter-2", 10 }
                };
        }

        public void InitiateSale(string item, int quantity)
        {
            if (Stocks[item] > quantity)
            {
                Stocks[item] = Stocks[item] - quantity;

                if (Stocks[item] < 5)
                {
                    if (Notifier != null)
                        Notifier(this, new StockChangeEvent(this.ID, item, 5, 10));

                }
            }
            else
            {
                Console.WriteLine($"Only {Stocks[item]} left, if you wish to buy please enter the quantity");
            }
        }
       
    }

    public class CentralStockMonitoringSystem : IStocksListener
    {
        public void ReceiveStockChangeNotification(object? obj,StockChangeEvent notification)
        {
            Console.WriteLine($"Stocks of Item:{notification.Itemname} is less than {notification.QuantityLeft} at {notification.SnacksVendingMachineID} ");
            Console.WriteLine($"Payment is on it way. . .");
        }       
    }


    public class SnackStockSupplier : IStocksListener
    {
        public void ReceiveStockChangeNotification(object? obj, StockChangeEvent notification)
        {
            Console.WriteLine($"Refilling {notification.QuantityToOrder} for {notification.SnacksVendingMachineID}");
        }
    }
}

