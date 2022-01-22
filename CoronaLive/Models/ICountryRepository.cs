using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaLive.Models
{
    public interface ICountryRepository
    {
        IQueryable<Country> Countries { get; }
    }
}
