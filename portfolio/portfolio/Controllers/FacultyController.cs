using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Dtos;
using portfolio.Models;
using portfolio.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        public PortfolioDbContext context;

        // GET: api/<FacultyController>
        public FacultyController(PortfolioDbContext _context)
        {
            context = _context;
        }
        [HttpGet("getall/{email}")]
        public  async Task<List<FacultyDto>>Get(string email)
        {

            var profile =await  context.Profiles.Include(x => x.study).Include(x => x.study.faculties).FirstAsync(profile => profile.email == email);
            return profile.study.faculties.AsDto();
        
        }

        // GET api/<FacultyController>/5
        [HttpGet("{id}")]
        public async Task<FacultyDto> Get(int id)
        {
            return (await context.Faculties.FirstAsync(faculty=>faculty.facultyId == id)).AsDto();
        }

        // POST api/<FacultyController>
        [HttpPost("{email}")]
        public async Task<string> Post(string email, [FromBody] FacultyDto faculty)
        {
            var profile = context.Profiles.Include(x => x.study).Include(x => x.study.faculties).First(pro => pro.email == email);
            try
            {
                var study =profile.study;
                study.faculties.Add(faculty.AsModel());
                context.SaveChanges();


                //study.faculties.Add(faculty.AsModel());

                //await context.SaveChangesAsync();
                return "done";
            }catch (Exception ex)
            {
                return ex.ToString();

            }

        }

        // PUT api/<FacultyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<FacultyController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            var faculty =  context.Faculties.First(faculty => faculty.facultyId == id);
            context.Faculties.Remove(faculty);
            await context.SaveChangesAsync();

        }
    }
}
