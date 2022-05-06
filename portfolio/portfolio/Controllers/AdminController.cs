using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using portfolio.Models;
using portfolio.Dtos;
using portfolio.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public PortfolioDbContext context;
        public AdminController(PortfolioDbContext _context)
        {
            context = _context;

        }
        // GET: api/<AdminController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> Get()
        {
            return  Ok( await context.Admins.ToListAsync());
        }

        // GET api/<AdminController>/5
        [HttpGet("{username}")]
        public async Task<AdminDto> GetUser(string username)
        {
            Admin result = await context.Admins.FirstAsync(admin => admin.username == username);
            return result.AsDto();
        }

        // POST api/<AdminController>
        [HttpPost]
        public async Task<string> Post(AdminDto admin)
        {
            var random = new Random();
            admin.verificationCode = random.Next(100000, 999999).ToString();
            await context.Admins.AddAsync(admin.AsModel());
            context.SaveChanges();
            return "verification code is : "+admin.verificationCode;

        }

        // PUT api/<AdminController>/5
        [HttpPut("/update/birth/{username}")]
        public async Task<string> PutAsync(string username, [FromBody] string value)
        {
            var admin = await context.Admins.FirstOrDefaultAsync(a => a.username == username);
            if (admin == null) return "Not Found";
            admin.birth = DateTime.Parse(value);
            context.SaveChanges();
            return "Done";

        }
        [HttpPut("/verify/{username}")]
        public async Task<string> Verify(string username , [FromBody] string verificationcode)
        {
            var admin= await context.Admins.FirstAsync(context=>context.username == username);
            admin.isVerified= (admin.verificationCode == verificationcode);
            return (admin.isVerified ? "verified." : "Wrong verification code.");
        }
        // DELETE api/<AdminController>/5
        [HttpDelete("/Delete/{username}")]
        public  async  Task<string> Delete(string username )

        {
            var admin =  await context.Admins.FirstAsync(admin => admin.username == username);
            if (admin == null) return "Not Found";
            context.Admins.Remove(admin);
            context.SaveChanges();
            return "Deleted";
        }




    }
}
