using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NewsletterAPI.Infrastructure;
using NewsletterAPI.Models;

namespace NewsletterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly NewsletterContext _context;

        public EmailsController(NewsletterContext context)
        {
            _context = context;
        }

        // GET: api/Emails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Email>>> GetEmails()
        {
          if (_context.Emails == null)
          {
              return NotFound();
          }
            return await _context.Emails.ToListAsync();
        }

        // POST: api/Emails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Email>> PostEmail([FromForm]string emailAddress)
        {
            if (emailAddress.IsNullOrEmpty())
            {
                return BadRequest();
            }

           var email = new Email { EmailAddress = emailAddress };

          if (_context.Emails == null)
          {
              return Problem("Entity set 'NewsletterContext.Emails'  is null.");
          }
            _context.Emails.Add(email);
            await _context.SaveChangesAsync();

            return  email;
        }
    }
}
