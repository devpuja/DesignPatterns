namespace Facade
{

    public interface IInventoryService
    {
        void ReserveInventory(string productId, int quantity);
    }

    public class InventoryService : IInventoryService
    {
        public void ReserveInventory(string productId, int quantity)
        {
           Console.WriteLine($"Reserved {quantity} units of product {productId} in inventory.");
        }
    }
}
