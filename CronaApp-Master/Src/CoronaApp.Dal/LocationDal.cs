using CoronaApp.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public class LocationDal: ILocationDal
    {
        private readonly CoronaContext _context;

        public LocationDal(CoronaContext context)
        {
            _context = context;
        }
    
        public async Task<List<Location>> GetAllLocations()
        {
            return  await _context.Locations.ToListAsync();
           
        }

        public async Task<List<Location>> GetLocationsByCity(string city)
        {
            return await _context.Locations.Where(location => location.City.Equals(city)).
                ToListAsync();
        }
    }
}
