using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiInventory.Models;
using WebApiInventory.Services;

namespace WebApiInventory.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IInventoryService _service;

        public DefaultController(IInventoryService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("AddInventoryItem")]
        public ActionResult<InventoryItem> AddInventoryItem(InventoryItem item)
        {
            var inventoryItem = _service.AddInventoryItem(item);

            if (inventoryItem == null)
            {
                return NotFound();
            }
            // test differences between them
            //return inventoryItem;
            return Ok(inventoryItem);
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItem>> GetInventoryItems()
        {
            var inventoryItems = _service.GetInventoryItems();

            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }

            return Ok(inventoryItems);
        }
    }
}