using Microsoft.EntityFrameworkCore;
using NewsletterAPI.Models;

namespace NewsletterAPI.Infrastructure
{
    public class NewsletterContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public NewsletterContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
