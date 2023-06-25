using CSI.Core.IRepositories;
using CSI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Infrastructure.Repositories
{
    public class ShipmentRepository : Repository<Shipment>, IShipmentRepository
    {
        private readonly ApplicationDbContext _context;

        public ShipmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async override Task<IEnumerable<Shipment>> GetAllAsync()
        {
            return await _context.Shipments.ToListAsync();
        }

        public async Task<IEnumerable<ShipmentDetail>> GetByShiperIdAsync(int shipperId)
        {

            var shipments = await _context.ShipmentDetails
        .FromSqlRaw("EXECUTE dbo.Shipper_Shipment_Details {0}", shipperId)
        .ToListAsync();

            return shipments;
        }
    }
}
