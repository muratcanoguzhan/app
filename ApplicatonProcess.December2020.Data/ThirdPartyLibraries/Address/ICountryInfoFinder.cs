using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicatonProcess.December2020.Data.ThirdPartyLibraries.Address
{
    public interface ICountryInfoFinder
    {
        Task<List<Country>> GetCountryinfo(string countryName);
        bool IsCountryExist(string countryName);
    }
}