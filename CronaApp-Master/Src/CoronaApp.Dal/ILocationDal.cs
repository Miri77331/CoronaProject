﻿using CoronaApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Dal
{
    public interface ILocationDal
    {
        Task<List<Location>> GetAllLocations();
        Task<List<Location>> GetLocationsByCity(string city);
    }
}
