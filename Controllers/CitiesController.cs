﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplyChainManagement.Models;
using SupplyChainManagement.OutputModels;

namespace SupplyChainManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly SupplyChainManagementContext _context;

        public CitiesController(SupplyChainManagementContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public ApiResponse<List<CityDTO>> GetCity()
        {
            List<CityDTO> result = _context.City.Select(x => new CityDTO { CityID = x.CityId, CityName = x.CityName }).ToList();
            return new ApiResponse<List<CityDTO>>(HttpStatusCode.OK, result);
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _context.City.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City city)
        {
            if (id != city.CityId)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ApiResponse<string>> PostCity([FromBody][Bind] AddCityDTO addCityDTO)
        {

            if (addCityDTO != null && addCityDTO.CityName != null)
            {
                if (_context.City.Where(x => x.CityName.ToLower() == addCityDTO.CityName.ToLower()).Count() == 0)
                {
                    _context.City.Add(new City { CityName = addCityDTO.CityName });
                    await _context.SaveChangesAsync();
                    return new ApiResponse<string>(HttpStatusCode.Created, "City added succesfully");
                } else
                {
                    return new ApiResponse<string>(HttpStatusCode.Conflict, "City already exists");
                }
            }
            else
            {
                return new ApiResponse<string>(HttpStatusCode.BadRequest, "City name is required");
            }

        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<City>> DeleteCity(int id)
        {
            var city = await _context.City.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.City.Remove(city);
            await _context.SaveChangesAsync();

            return city;
        }

        private bool CityExists(int id)
        {
            return _context.City.Any(e => e.CityId == id);
        }
    }
}
