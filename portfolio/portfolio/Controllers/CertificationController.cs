﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationController : ControllerBase
    {
        // GET: api/<CertificationController>
        [HttpGet]
        public void  Get()
        {
            return;        }

        // GET api/<CertificationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CertificationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CertificationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CertificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
