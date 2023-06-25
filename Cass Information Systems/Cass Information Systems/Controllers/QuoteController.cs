using AutoMapper;
using CIS.SharedKernel.ViewModels;
using CSI.Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Cass_Information_Systems.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : ControllerBase
    {
  

        private readonly IQuoteService _quoteService;
        private readonly IMapper _mapper;
        public QuoteController(IQuoteService quoteService,IMapper mapper)
        {
            _quoteService = quoteService;
            _mapper = mapper;
        }
        /// api/Shipment/GetShippers
        /// <summary>
        /// Action to get all shippers
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet("RandomQuote")]
        public async Task<IActionResult> RandomQuote()
        {
            var quote = await _quoteService.GetRandomAsync();

            return Ok(quote);
        }

        /// api/Shipment/GetShippments
        /// <summary>
        /// Action to get  quotes by authorName 
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet("Get/{authorName}")]
        public async Task<IActionResult> Get(string authorName = "")
        {
            var quotes = await _quoteService.GetQuotesGroupedByLength(authorName);

            return Ok(quotes);
        }
    }
}