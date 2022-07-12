﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoronaApp.Dal.Models;
using CoronaApp.Dal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationDal _locationDal;

        public LocationController(LocationDal locationDal)
        {
            _locationDal = locationDal;
        }        
        //get all locations
        // GET: api/<LocationsController>
        [HttpGet]
        public async Task<ActionResult<List<Location>>> Get()
        {
            var res = await _locationDal.GetAllLocations();
            if (res == null)
            {
                return NotFound();
            }
            return res;
        }

        //get locations by city
        // GET api/<LocationsController>/5
        [HttpGet("city")]
        public async Task<ActionResult<List<Location>>> Get([FromQuery] string city)
        {
            var res = await _locationDal.GetLocationsByCity(city);
            if (res == null)
            {
                return NotFound();
            }
            return res;
        }

     

      
    }
}
