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
    public class ShipperService : IShipperService
    {
        private readonly IShipperRepository _shipperRepository;

        public ShipperService(IShipperRepository shipperRepository)
        {
            _shipperRepository = shipperRepository;
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
            return await _shipperRepository.GetAllAsync();
        }


        public Task<Shipper> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}