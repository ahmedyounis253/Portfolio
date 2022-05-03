using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public PortfolioDbContext context { get; set; }
        AdminController(PortfolioDbContext _context)
        {
            context = _context;

        }
        // GET: api/<AdminController>
        [HttpGet]
        public async Task<IEnumerable<Admin>> Get()
        {
            return await context.Admins.ToListAsync();
        }

        // GET api/<AdminController>/5
        [HttpGet("{id}")]
        public async Task<Admin> GetUser(string username)
        {
            return await context.Admins.FirstAsync(admin => admin.username == username);
        }

        // POST api/<AdminController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            return;
        }

        // PUT api/<AdminController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdminController>/5
        [HttpDelete("{id}")]
        public  void Delete(string username )

        {
            var admin =  context.Admins.First(admin => admin.username == username);
            context.Admins.Remove(admin);

        }

    }
}
