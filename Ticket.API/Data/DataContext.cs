using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ticket.Shared.Entities;

namespace Ticket.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

     
        public DbSet<Tickete> Ticketes { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
          
        }
    }
}
