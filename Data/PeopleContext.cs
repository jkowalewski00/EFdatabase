using EFdatabase.Models;
using Microsoft.EntityFrameworkCore;


namespace EFdatabase.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Person { get; set; }
    }
}
