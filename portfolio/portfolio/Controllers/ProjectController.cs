using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;
using portfolio.Data;
using portfolio.Dtos;
using portfolio.pagging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        public PortfolioDbContext context;
        public ProjectController(PortfolioDbContext _context)
        {
            context = _context;


        }

        // GET: api/<ProjectController>
        [HttpGet("getall/{email}")]
        public async Task<List<Project>> GetAsync(string email,[FromQuery] ObjectPaging parameters)
        {
            var profile= await context.Profiles.Include(projects=>projects.projects).FirstAsync(projects=>projects.email == email);
            var projects = profile.projects;
            var pagedprojects= PagedList<Project>.ToPaging(projects, parameters.pageNumber, parameters.pageSize);
            Response.Headers.Add("Pagging", JsonConvert.SerializeObject(pagedprojects.metaData));
            return pagedprojects.ToList();
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public async Task<Project> Get(int id)
        {
            var project = await context.Projects.FirstAsync(project=>project.projectId == id);

            return project;
        }

        // POST api/<ProjectController>
        [HttpPost]
        public async Task<string>  Post(string email,[FromBody] ProjectDto project)
        {
            var profile= await context.Profiles.Include(projects=>projects.projects).FirstAsync(projects=>projects.email == email);
            profile.projects.Add(project.AsModel());
            await context.SaveChangesAsync();
            return "project added successfully.";


        }

        // PUT api/<ProjectController>/5
        [HttpPut("update/{id}")]
        public async Task<string> Put(int id, [FromBody] ProjectDto projectDto)
        {
            var project = await context.Projects.FirstAsync(project => project.projectId == id);
            project.title=projectDto.title;
            project.description=projectDto.description;
            project.github=projectDto.github;
            project.usedSkills=projectDto.usedSkills;
            project.vedioPath=projectDto.vedioPath;
            project.date = projectDto.date;
            await context.SaveChangesAsync();
            return "Project updated successfully.";


        }


        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            var project = await context.Projects.FirstAsync(project => project.projectId == id);
            context.Projects.Remove(project);
            await context.SaveChangesAsync();
            return "Project deleted successfully.";
        }
    }
}
