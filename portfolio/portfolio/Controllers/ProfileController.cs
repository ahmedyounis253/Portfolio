using Microsoft.AspNetCore.Mvc;
using portfolio.Dtos;
using portfolio.Models;
using portfolio.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        public PortfolioDbContext context;
        public ProfileController(PortfolioDbContext _context)
        {
            context = _context;


        }
        
        // GET api/<ProfileController>/5
        [HttpGet("{email}")]
        public async Task<ProfileDto> Get(string email)
        {
            Profile profile = await context.Profiles.FirstAsync(profile => profile.email == email);

            return profile.AsDto();

        }

        // POST api/<ProfileController>
        [HttpPost]
        public async Task<string> Post([FromBody] ProfileDto profile)
        {
            var prof = profile.AsModel();
            prof.study = new Study();
            prof.study.certifications=new List<Certification>();
            prof.study.faculties=new List<Faculty>();
            context.Profiles.Add(prof);
            await context.SaveChangesAsync();
            return "profile added.";

        }

        // PUT api/<ProfileController>/5
        [HttpPut("/update/linkedin/{email}")]
        public async Task<string> Put(string email, [FromBody] Uri linkedin)
        {
            var profile = context.Profiles.First(profile => profile.email == email);
            profile.linkedin = linkedin;
            await context.SaveChangesAsync();
            return "Updated Successfully.";

        }
        [HttpPut("/update/hackerrank/{email}")]
        public async Task<string> PutHackerRack(string email, [FromBody] Uri hackerrack)
        {
            var profile = context.Profiles.First(profile => profile.email == email);
            profile.hackerRank = hackerrack;
            await context.SaveChangesAsync();
            return "Updated Successfully.";

        }
        [HttpPut("/update/leetcode/{email}")]
        public async Task<string> PutLeetCode(string email, [FromBody] Uri leetCode)
        {
            var profile = context.Profiles.First(profile => profile.email == email);
            profile.leetcode = leetCode;
            await context.SaveChangesAsync();
            return "Updated Successfully.";

        }
        [HttpPut("/update/email/{email}")]
        public async Task<string> PutEmail(string email, [FromBody] string email2)
        {
            var profile = context.Profiles.First(profile => profile.email == email);
            profile.email = email2;
            await context.SaveChangesAsync();
            return "Updated Successfully.";

        }
        [HttpPut("/update/description/{email}")]
        public async Task<string> PutDescription(string email, [FromBody] string description)
        {
            var profile = context.Profiles.First(profile => profile.email == email);
            profile.description = description;
            await context.SaveChangesAsync();
            return "Updated Successfully.";

        }

        // DELETE api/<ProfileController>/5
        [HttpDelete("{email}")]
        public async Task<string> Delete(string email)
        {
            var profile =await  context.Profiles.FirstAsync(profile => profile.email == email);
            context.Remove(profile);
            await context.SaveChangesAsync();
            return "Deleted.";

        }
    }
}
