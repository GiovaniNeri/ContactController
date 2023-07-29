using Microsoft.EntityFrameworkCore;

namespace ContactController.DBContext
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Contact> Contacts { get; set;}
    }
}
