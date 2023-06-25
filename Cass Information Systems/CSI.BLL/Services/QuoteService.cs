
using CIS.SharedKernel.Response;
using CSI.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSI.Core.IServices
{
    public class QuoteService : IQuoteService
    {

        private static readonly HttpClient client = new HttpClient();

        public async Task<Quote> GetRandomAsync()
        {
            var response = await client.GetAsync("https://api.quotable.io/quotes/random");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();

            var randomQuote = JsonConvert.DeserializeObject<List<Quote>>(stringResponse);
            return randomQuote.FirstOrDefault();
        }

        public async Task<Dictionary<string, List<Quote>>> GetQuotesGroupedByLength(string authorName)
        {
            var einsteinQuotes = new List<Quote>();


            var response = await client.GetAsync($"https://api.quotable.io/quotes?author={authorName}");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();

            var quotes = JsonConvert.DeserializeObject<Quotes>(stringResponse);
            einsteinQuotes.AddRange(quotes.results);


            einsteinQuotes = einsteinQuotes.Take(30).ToList();

            var groupedQuotes = new Dictionary<string, List<Quote>>
            {
                ["Short"] = einsteinQuotes.Where(q => q.content.Split(' ').Length < 10).ToList(),
                ["Medium"] = einsteinQuotes.Where(q => q.content.Split(' ').Length >= 11 && q.content.Split(' ').Length <= 20).ToList(),
                ["Long"] = einsteinQuotes.Where(q => q.content.Split(' ').Length > 20).ToList(),
            };

            return groupedQuotes;
        }
    }
}
