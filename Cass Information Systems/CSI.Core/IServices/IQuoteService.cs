
using CIS.SharedKernel.Response;
using CSI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSI.Core.IServices
{
    public interface IQuoteService
    {
        Task<Quote> GetRandomAsync();
        Task<Dictionary<string, List<Quote>>> GetQuotesGroupedByLength(string authorName);
    }
   
}
