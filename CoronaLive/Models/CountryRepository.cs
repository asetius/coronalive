using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaLive.Models
{
    public class CountryRepository : ICountryRepository
    {
        public IQueryable<Country> Countries => new List<Country>
        {
            new Country {CountryName = "USA", TotalCases = 70544862, TotalRecovered = 44047799},
            new Country {CountryName = "India", TotalCases = 38566027, TotalRecovered = 36058806},
            new Country {CountryName = "Brazil", TotalCases = 23588921, TotalRecovered = 21851922},
            new Country {CountryName = "UK", TotalCases = 15613283, TotalRecovered = 11850874},
            new Country {CountryName = "France", TotalCases = 15600647, TotalRecovered = 9844686},
            new Country {CountryName = "Russia", TotalCases = 10938261, TotalRecovered = 9950333},
            new Country {CountryName = "Turkey", TotalCases = 10736215, TotalRecovered = 9985596},
            new Country {CountryName = "Italy", TotalCases = 9418256, TotalRecovered = 6593625},
            new Country {CountryName = "Spain", TotalCases = 8834363, TotalRecovered = 5417226},
            new Country {CountryName = "Germany", TotalCases = 8397328, TotalRecovered = 7216200}
        }.AsQueryable<Country>();
    }
}
