using Backend.Domain.Entities;
using Backend.Domain.Interfaces;
using Backend.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Repositories
{
    public class FootballerRepository : IFootballerRepository
    {
        private readonly FootballersDbContext _context;
        public FootballerRepository(FootballersDbContext context) 
        {
            _context = context;
        }
        public List<Footballer> GetAllFootballers() => _context.Footballers.Where(x => x.IsDeleted == false).ToList();

        public Footballer GetFootballer(Guid guid) => _context.Footballers.First(x => x.Guid == guid);
    }
}
