using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Interfaces
{
    public interface IFootballerRepository
    {
        List<Footballer> GetAllFootballers();
        Footballer GetFootballer(Guid guid);
        Task DeleteFootballer(Guid guid);

        Task CreateNewFootballer(Footballer footballer);

        Task UpdateFootballer(Footballer footballer);
    }
}
