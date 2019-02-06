using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventory.Models;

namespace WebApiInventory.Services
{
    public interface IInventoryService
    {
        InventoryItem AddInventoryItem(InventoryItem inventoryItem);
        Dictionary<string, InventoryItem> GetInventoryItems();
    }
}
