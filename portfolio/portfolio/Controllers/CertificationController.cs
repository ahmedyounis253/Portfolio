using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Dtos;
using portfolio.Data;
using portfolio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationController : ControllerBase
    {

        public PortfolioDbContext context;

        public CertificationController(PortfolioDbContext _context)
        {
            context = _context;
        }
        // GET: api/<CertificationController>
        [HttpGet("/getall/{email}")]
        public async Task<List<CertificationDto>>Get(string email)
        {
            Console.WriteLine(email);
            var profile = await context.Profiles.Include(x => x.study).Include(x=>x.study.certifications).FirstAsync(pr => pr.email == email);
            return profile.study.certifications.AsDto();
        }
        // GET api/<CertificationController>/5
        [HttpGet("{certificationId}")]
        public async Task<CertificationDto> Get(int certificationId)
        {
            return (await context.Certifications.FirstAsync(cert => cert.certificationId == certificationId)).AsDto();

        }

        // POST api/<CertificationController>
        [HttpPost("{email}")]
        public async Task<string> Post(string email,[FromBody] CertificationDto certification)
        {
            var profile =await context.Profiles.Include(x => x.study).Include(x => x.study.certifications).FirstAsync(profile => profile.email == email);
            profile.study.certifications.Add(certification.AsModel());
            context.SaveChanges();
            return "Certification added.";

        }



        // DELETE api/<CertificationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var certification= await context.Certifications.FirstAsync(cert=>cert.certificationId==id);
            context.Certifications.Remove(certification);
        }
    }
}
