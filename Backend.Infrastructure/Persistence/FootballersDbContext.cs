using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Persistence
{
    public partial class FootballersDbContext : DbContext
    {
        public DbSet<Domain.Entities.Footballer> Footballers { get; set; }

        public FootballersDbContext(DbContextOptions<FootballersDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Footballer>()
                .Property(e => e.Id).ValueGeneratedOnAdd();
        }

    }
}
