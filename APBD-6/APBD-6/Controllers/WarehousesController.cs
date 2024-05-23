using APBD_6.Models;
using APBD_6.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_6.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehousesController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPost]
        public ActionResult AddProduct(ProductWarehouse product)
        {
            _warehouseService.AddProduct(product);
            return Ok();
        }
    }