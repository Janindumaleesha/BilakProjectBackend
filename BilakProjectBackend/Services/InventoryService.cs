using BilakProjectBackend.Models;

namespace BilakProjectBackend.Services
{
    public class InventoryService : IInventory
    {
        private readonly BilakDbContext _context = new BilakDbContext();
        public Inventory CreateInventory(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
            return inventory;
        }

        public void DeleteInventory(int id)
        {
            var inventory = _context.Inventories.FirstOrDefault(i => i.Id == id);
            if (inventory != null)
            {
                _context.Inventories.Remove(inventory);
                _context.SaveChanges();
            }
        }

        public Inventory GetInventoryById(int id)
        {
            var inventory = _context.Inventories.FirstOrDefault(i => i.Id == id);
            if (inventory != null)
            {
                return inventory;
            }
            return null;
        }

        public List<Inventory> GetInventorys()
        {
            return _context.Inventories.ToList();
        }

        public void UpdateInventory(int id, Inventory inventory)
        {
            var updateInventory = _context.Inventories.FirstOrDefault(i => i.Id == id);
            if (updateInventory != null)
            {
                _context.Inventories.Update(inventory);
                _context.SaveChanges();
            }
        }
    }
}
