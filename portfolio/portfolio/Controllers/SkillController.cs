using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Data;
using portfolio.Dtos;
using portfolio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {

        public PortfolioDbContext context;
        public SkillController(PortfolioDbContext _context)
        {
            context = _context;


        }

        // GET: api/<SkillController>
        [HttpGet("getall/{email}")]
        public async Task<List<Skill>> GetAsync(string email)
        {
            var profile = await context.Profiles.Include(s => s.skills).FirstAsync(p => p.email == email);
            return profile.skills.Select(x=>new Skill { title=x.title,skillId=x.skillId,rate=x.rate,description=x.description}).ToList();
        }

        // GET api/<SkillController>/5
        [HttpGet("{id}")]
        public Skill Get(int id)
        {
            return (context.Skills.Select(x => new Skill { title = x.title, skillId = x.skillId, rate = x.rate, description = x.description }).ToList().First(s => s.skillId == id));

        }

        // POST api/<SkillController>
        [HttpPost("{email}")]
        public async Task PostAsync(string email ,[FromBody]  SkillDto skill)
        {
            var profile = await context.Profiles.Include(p=>p.skills).FirstAsync(p => p.email == email);
            profile.skills.Add(skill.AsModel());
            context.SaveChangesAsync();

        }

        // PUT api/<SkillController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SkillDto skill)
        {
            var oldSkill= context.Skills.First(s=>s.skillId == id);
            oldSkill.title=skill.title;
            oldSkill.description=skill.description;
            oldSkill.rate=skill.rate;
            context.SaveChangesAsync();

        }

        // DELETE api/<SkillController>/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteAsync(int id)
        {
            var skill= context.Skills.First(s=>s.skillId == id);
            context.Skills.Remove(skill);
            await context.SaveChangesAsync();
            return "Deleted.";
        }
    }
}
