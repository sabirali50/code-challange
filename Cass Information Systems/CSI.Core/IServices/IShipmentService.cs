
using CSI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSI.Core.IServices
{
    public interface IShipmentService
    {
        Task<Shipment> CreateAsync(Shipment entity);
        Task<IEnumerable<ShipmentDetail>> GetByShipperIdAsync(int shipperId);
        Task<int> UpdateAsync(Shipment entity);
        Task<int> RemoveByIdAsync(int id);
        Task<IEnumerable<Shipment>> GetAllAsync();
    }
   
}
