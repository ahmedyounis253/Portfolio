using Microsoft.AspNetCore.Mvc;
using portfolio.Dtos;
using portfolio.Models;
using portfolio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

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

  
        
        [HttpPut("update/{email}")]
        public async Task<string> Put(string email, [FromBody] ProfileDto profile)
        {
            var pro = context.Profiles.First(profile => profile.email == email);
            pro.description = profile.description;
            pro.leetcode = profile.leetcode;
            pro.name = profile.name;
            pro.preferedName = profile.preferedName;
            pro.hackerRank=profile.hackerRank;
            pro.linkedin = profile.linkedin;
            pro.email= profile.email;
            if (profile.imageUrl.ToString().Contains("http") || profile.imageUrl.ToString().Contains("https"))
            {
                pro.imageUrl=profile.imageUrl;
            }
            else
            {
                pro.imageUrl = new Uri("https://localhost:7210/" + profile.imageUrl.ToString());
            }
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
