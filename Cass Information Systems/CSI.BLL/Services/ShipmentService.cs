using CSI.Core.IRepositories;
using CSI.Core.IServices;
using CSI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace CSI.Infrastructure.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentService(IShipmentRepository shipnmentRepository)
        {
            _shipmentRepository = shipnmentRepository;
        }

        public async Task<Shipper> CreateAsync(Shipper booking)
        {
            throw new NotImplementedException();
        }


        public async Task<int> RemoveByIdAsync(int bookingId)
        {
            throw new NotImplementedException();

        }

        public async Task<int> UpdateAsync(Shipper booking)
        {
            throw new NotImplementedException();

        }

        public async Task<IEnumerable<Shipper>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public Task<Shipment> CreateAsync(Shipment entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShipmentDetail>> GetByShipperIdAsync(int shipperId)
        {
            return await _shipmentRepository.GetByShiperIdAsync(shipperId);
        }

        public Task<int> UpdateAsync(Shipment entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Shipment>> IShipmentService.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}