using AutoMapper;
using CIS.SharedKernel.ViewModels;
using CSI.Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Cass_Information_Systems.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipmentController : ControllerBase
    {
  

        private readonly IShipmentService _shipmentService;
        private readonly IShipperService _shipperService;
        private readonly IMapper _mapper;
        public ShipmentController(IShipmentService shipmentService, IShipperService shipperService, IMapper mapper)
        {
            _shipperService = shipperService;
            _shipmentService = shipmentService;
            _mapper = mapper;
        }
        /// api/Shipment/GetShippers
        /// <summary>
        /// Action to get all shippers
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet("All")]
        public async Task<IActionResult> All()
        {
            var shippers = await _shipperService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ShipperViewModel>>(shippers));
        }

        /// api/Shipment/GetShippments
        /// <summary>
        /// Action to get shipments by shipper ID
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet("Get/{shipperId}")]
        public async Task<IActionResult> Get(int shipperId)
        {
            var shipments = await _shipmentService.GetByShipperIdAsync(shipperId);

            return Ok(shipments);
        }
    }
}