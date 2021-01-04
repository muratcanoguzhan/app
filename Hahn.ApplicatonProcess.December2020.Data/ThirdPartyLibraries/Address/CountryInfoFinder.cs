using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hahn.ApplicatonProcess.December2020.Data.ThirdPartyLibraries.Address
{
    public class CountryInfoFinder : ICountryInfoFinder
    {
        private readonly IHttpClientFactory _clientFactory;

        public CountryInfoFinder(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<Country>> GetCountryinfo(string countryName)
        {
            var url = $"https://restcountries.eu/rest/v2/name/{countryName}?fullText=true";

            var client = _clientFactory.CreateClient();

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var responseBodyStr = await response.Content.ReadAsStringAsync();
                var c = JsonConvert.DeserializeObject<List<Country>>(responseBodyStr);
                return c;
            }
            return null;
        }

        public bool IsCountryExist(string countryName)
        {
            var countries = AsyncHelper.RunSync(() => GetCountryinfo(countryName));
            return countries != null && countries.Any(c => c.name == countryName);
        }
    }
}
