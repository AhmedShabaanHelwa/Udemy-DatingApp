using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Vid 11
    public class DataContext : DbContext
    {
        //1 - passing options to DbContext
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // 2 - Create the tables of database
        public DbSet<AppUser> Users { get; set; }
    }
}