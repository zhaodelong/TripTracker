﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private Repository _Repository;

        public TripsController(Repository repository)
        {
            _Repository = repository;
        }

        // GET api/Trips
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _Repository.Get();
        }

        // GET api/Trips/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _Repository.Get(id);
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody]Trip value)
        {
            _Repository.Add(value);
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip value)
        {
            _Repository.Update(value);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _Repository.Remove(id);
        }
    }
}
