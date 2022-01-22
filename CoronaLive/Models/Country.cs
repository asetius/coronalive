using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaLive.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? CountryName { get; set; }
        public int TotalCases { get; set; }
        public int TotalRecovered { get; set; }
    }
}
