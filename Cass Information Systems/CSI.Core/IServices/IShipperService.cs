
using CSI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSI.Core.IServices
{
    public interface IShipperService
    {
        Task<Shipper> CreateAsync(Shipper entity);
        Task<Shipper> GetByIdAsync(int id);
        Task<int> UpdateAsync(Shipper entity);
        Task<int> RemoveByIdAsync(int id);
        Task<IEnumerable<Shipper>> GetAllAsync();
    }
   
}
