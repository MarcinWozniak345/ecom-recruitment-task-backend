using Backend.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Services
{
    public interface IFootballerService
    {
        List<FootballerDTO> GetAllFootballers();
        FootballerDTO GetFootballer(Guid guid);
        Task DeleteFootballer(Guid guid);
        Task CreateFootballer(CreateFootbalerDTO newFootballer);
        Task UpdateFootballer(UpdateFootbalerDTO updatedFootballer);
    }
}
