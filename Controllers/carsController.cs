using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using G6API.ControllerMethods;
using G6API.Models;


namespace G6API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class carsController : ControllerBase
    {
        // GET: api/cars
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Car> Get()
        {
            ReadCarData rdr = new ReadCarData();
            return rdr.GetAllCars();
        }

        // // GET: api/cars/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST: api/cars
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Car value)
        {
            EditCarData ecd = new EditCarData();
            ecd.AddCar(value);
        }

        // PUT: api/cars/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car value)
        {
            EditCarData ecd = new EditCarData();
            ecd.EditCar(id, value);
        }

        // DELETE: api/cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
