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
    public class ShipperRepository : Repository<Shipper>, IShipperRepository
    {
        private readonly ApplicationDbContext _context;

        public ShipperRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async override Task<IEnumerable<Shipper>> GetAllAsync()
        {
            return await _context.Shippers.ToListAsync();
        }

        public async override Task<Shipper> GetByIdAsync(int id)
        {
            var shipper = await this.context.Shippers.Where(x => x.ShipperId == id).FirstOrDefaultAsync();

            return shipper;
        }
    }
}
