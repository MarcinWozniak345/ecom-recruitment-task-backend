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

        public async Task CreateNewFootballer(Footballer footballer)
        {
            footballer.Guid = Guid.NewGuid();
            _context.Footballers.Add(footballer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFootballer(Guid guid)
        {
            var f = _context.Footballers.First(x => x.Guid == guid);
            _context.Footballers.Remove(f);
            await _context.SaveChangesAsync();
        }

        public List<Footballer> GetAllFootballers() => _context.Footballers.Where(x => x.IsDeleted == false).ToList();

        public Footballer GetFootballer(Guid guid) => _context.Footballers.First(x => x.Guid == guid);

        public async Task UpdateFootballer(Footballer footballer)
        {
            var f = _context.Footballers.First(x => x.Guid == footballer.Guid);
            f.Name = footballer.Name;
            f.Surname = footballer.Surname;
            f.Assists = footballer.Assists;
            f.Age = footballer.Age;
            f.NumberOfMatches = footballer.NumberOfMatches;
            f.Goals = footballer.Goals;
            f.Nationality = footballer.Nationality;
            f.Number = footballer.Number;
            await _context.SaveChangesAsync();

        }
    }
}
