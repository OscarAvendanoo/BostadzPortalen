﻿using AutoMapper;
using BostadzPortalenWebAPI.Data;
using BostadzPortalenWebAPI.DTO;
using BostadzPortalenWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BostadzPortalenWebAPI.Controllers
{
    //Author: Johan Nelin
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstateAgencyController : ControllerBase
    {
        private readonly IRealEstateAgencyRepository _realEstateAgencyRepository;
        public RealEstateAgencyController(IRealEstateAgencyRepository realEstateAgencyRepository)
        {
            this._realEstateAgencyRepository = realEstateAgencyRepository;
        }


        // GET: api/<PropertyForSaleController>
        [HttpGet]
        public async Task<IEnumerable<RealEstateAgency>> GetAllAgencies()
        {
            return await _realEstateAgencyRepository.GetAllAsync();
        }

        // GET api/<PropertyForSaleController>/5
        [HttpGet("{id}")]
        public async Task<RealEstateAgency> GetAgencyById(int id)
        {
            return await GetAgencyById(id);
        }

        // POST api/<PropertyForSaleController>
        [HttpPost]
        public async Task<ActionResult> CreateAgency([FromBody] RealEstateAgency agency)
        {
            try
            {
                await _realEstateAgencyRepository.AddAsync(agency);
                return Ok(agency);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        // PUT api/<PropertyForSaleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAgency(int id) //this doesn't take in any info to update the agency with
        {
            try
            {
                var agency = await _realEstateAgencyRepository.GetByIDAsync(id);

                await _realEstateAgencyRepository.UpdateAsync(agency);
                return Ok(agency);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occured " + ex.Message);
            }
        }

        // DELETE api/<PropertyForSaleController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAgency(int id)
        {
            await _realEstateAgencyRepository.DeleteAsync(await GetAgencyById(id)); //this probably shouldn't be used like this
        }
    }
}
