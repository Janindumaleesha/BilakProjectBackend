using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public interface IInventory
    {
        public List<Inventory> GetInventorys();
        public Inventory GetInventoryById(int id);
        public Inventory CreateInventory(Inventory inventory);
        public void UpdateInventory(int id, Inventory inventory);
        public void DeleteInventory(int id);
    }
}
