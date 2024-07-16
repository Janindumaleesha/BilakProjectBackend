using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IInventory
    {
        public List<Inventory> GetInventorys();
        public Inventory GetInventoryById(int id);
        public Inventory CreateInventory(Inventory inventory);
        public Inventory UpdateInventory(Inventory inventory);
        public Inventory DeleteInventory(int id);
    }
}
