using Backend.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Seeders
{
    public class FootballersSeeder
    {
        private readonly FootballersDbContext _dbContext;
        public FootballersSeeder(FootballersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.Footballers.Any())
                {

                }
            }
        }


    }
}
