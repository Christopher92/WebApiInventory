using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventory.Models;

namespace WebApiInventory.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly Dictionary<string, InventoryItem> _inventoryItem;

        public InventoryService()
        {
            _inventoryItem = new Dictionary<string, InventoryItem>(); 
        }
        public InventoryItem AddInventoryItem(InventoryItem inventoryItem)
        {
            _inventoryItem.Add(inventoryItem.Name, inventoryItem);

            return inventoryItem;
        }

        public Dictionary<string, InventoryItem> GetInventoryItems()
        {
            return _inventoryItem;
        }
    }
}
