
using CSI.Core.Models;

namespace CSI.Core.IRepositories
{
    public interface IShipmentRepository : IRepository<Shipment>
    {
        public Task<IEnumerable<ShipmentDetail>> GetByShiperIdAsync(int shipperId);
    }
}