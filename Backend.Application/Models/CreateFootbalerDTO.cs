using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Models
{
    public class CreateFootbalerDTO
    {
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public int Number { get; set; }
        public string Position { get; set; } = default!;
        public string Nationality { get; set; } = default!;
        public int NumberOfMatches { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Age { get; set; }
    }
}
