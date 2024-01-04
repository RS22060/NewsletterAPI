using NewsletterAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace NewsletterAPI.Models
{
    public class Email
    {
        public int EmailId { get; set; }

        public string? EmailAddress { get; set; }
    }

}
