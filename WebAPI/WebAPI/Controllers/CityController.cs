using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using WebAPI.Data;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly dataDbContext dc;
        public CityController(dataDbContext dc)
        {
            this.dc = dc;
        }
        //Get api/city
        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
            var cities = await dc.Cities.ToListAsync();
            return Ok(cities);
        }

        //post api/city/post
        [HttpPost("post")]
        public async Task<IActionResult> AddCity(City city)
        {
            //City city = new City();
            //city.Name = cityname;
            await dc.Cities.AddAsync(city);
            await dc.SaveChangesAsync();
            return Ok(city);
        }

        //post api/city/add?cityname=Miami
        [HttpPost("add")]
        [HttpPost("add/{cityname}")]
        public async Task<IActionResult> AddCity(string cityname)
        {
            City city = new City();
            city.Name = cityname;
            await dc.Cities.AddAsync(city);
            await dc.SaveChangesAsync();
            return Ok(city);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await dc.Cities.FindAsync(id);
            dc.Cities.Remove(city);
            await dc.SaveChangesAsync();
            return Ok(id);
        }



        [HttpGet("{id}")]
        public IEnumerable<string> GetById(int id)
        {
            return new string[] { "Atlena", "York" };
        }
    }
}