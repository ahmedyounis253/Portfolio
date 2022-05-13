using Microsoft.AspNetCore.Mvc;
using portfolio.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolioServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {

        // POST api/<MailController>
        [HttpPost]
        public void Post([FromBody] Mail mail)
        {
            SendMail mailMessage =new SendMail(mail.toMail,mail.subject,mail.body,"Dear");

        }

        // PUT api/<MailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
