using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoronaApp.Dal;
using CoronaApp.Dal.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientDal _patientDal;
        public PatientController(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        // GET api/<UserController>/5
        [HttpGet("{patintId}")]
        public async Task<ActionResult<List<Location>>> Get(string patintId)
        {
            var res = await _patientDal.GetPatientLocations(patintId);
            if (res == null)
            {
                return NotFound();
            }
            return res;

        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<Location>> Post([FromBody] Location location)
        {
            return await _patientDal.PostLocation(location);
        }

        // DELETE api/<UserController>
        [HttpDelete("{locationId}")]
        public async Task Delete(int locationId)
        {
            await _patientDal.DeleteLocation(locationId);
        }
    }
}
