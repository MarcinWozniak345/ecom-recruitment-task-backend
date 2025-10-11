using Backend.Domain.Entities;
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
                    var footballers = new List<Footballer>
                    {
                        new Footballer {
                            Name = "Alisson",
                            Surname = "Becker",
                            Number = 1,
                            Position = "Bramkarz",
                            Nationality = "Brazylia",
                            NumberOfMatches = 38,
                            Goals = 0,
                            Assists = 3,
                            Age = 32,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Caoimhín",
                            Surname = "Kelleher",
                            Number = 62,
                            Position = "Bramkarz",
                            Nationality = "Irlandia",
                            NumberOfMatches = 12,
                            Goals = 0,
                            Assists = 0,
                            Age = 26,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Joe",
                            Surname = "Gomez",
                            Number = 2,
                            Position = "Obrońca",
                            Nationality = "Anglia",
                            NumberOfMatches = 28,
                            Goals = 0,
                            Assists = 2,
                            Age = 28,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Virgil",
                            Surname = "van Dijk",
                            Number = 4,
                            Position = "Obrońca",
                            Nationality = "Holandia",
                            NumberOfMatches = 36,
                            Goals = 5,
                            Assists = 2,
                            Age = 33,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Ibrahima",
                            Surname = "Konaté",
                            Number = 5,
                            Position = "Obrońca",
                            Nationality = "Francja",
                            NumberOfMatches = 30,
                            Goals = 2,
                            Assists = 1,
                            Age = 26,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Andy",
                            Surname = "Robertson",
                            Number = 26,
                            Position = "Obrońca",
                            Nationality = "Szkocja",
                            NumberOfMatches = 38,
                            Goals = 2,
                            Assists = 10,
                            Age = 31,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Trent",
                            Surname = "Alexander-Arnold",
                            Number = 66,
                            Position = "Obrońca / pomocnik",
                            Nationality = "Anglia",
                            NumberOfMatches = 37,
                            Goals = 4,
                            Assists = 18,
                            Age = 26,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Jarell",
                            Surname = "Quansah",
                            Number = 78,
                            Position = "Obrońca",
                            Nationality = "Anglia",
                            NumberOfMatches = 34,
                            Goals = 3,
                            Assists = 1,
                            Age = 22,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Kostas",
                            Surname = "Tsimikas",
                            Number = 21,
                            Position = "Obrońca",
                            Nationality = "Grecja",
                            NumberOfMatches = 20,
                            Goals = 0,
                            Assists = 3,
                            Age = 29,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Alvarez",
                            Surname = "—",   
                            Number = 3,
                            Position = "Pomocnik / Obrońca",
                            Nationality = "Argentyna",
                            NumberOfMatches = 18,
                            Goals = 1,
                            Assists = 1,
                            Age = 24,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Mohamed",
                            Surname = "Salah",
                            Number = 11,
                            Position = "Napastnik / Skrzydłowy",
                            Nationality = "Egipt",
                            NumberOfMatches = 38,
                            Goals = 34,
                            Assists = 18,
                            Age = 31,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Cody",
                            Surname = "Gakpo",
                            Number = 18,
                            Position = "Napastnik / Skrzydłowy",
                            Nationality = "Holandia",
                            NumberOfMatches = 36,
                            Goals = 18,
                            Assists = 7,
                            Age = 26,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Luis",
                            Surname = "Díaz",
                            Number = 7,
                            Position = "Napastnik / Skrzydłowy",
                            Nationality = "Kolumbia",
                            NumberOfMatches = 34,
                            Goals = 17,
                            Assists = 6,
                            Age = 28,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Darwin",
                            Surname = "Núñez",
                            Number = 9,
                            Position = "Napastnik",
                            Nationality = "Urugwaj",
                            NumberOfMatches = 32,
                            Goals = 7,
                            Assists = 2,
                            Age = 25,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Diogo",
                            Surname = "Jota",
                            Number = 20,
                            Position = "Napastnik / Skrzydłowy",
                            Nationality = "Portugalia",
                            NumberOfMatches = 25,
                            Goals = 9,
                            Assists = 2,
                            Age = 27,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Alexis",
                            Surname = "Mac Allister",
                            Number = 10,
                            Position = "Pomocnik",
                            Nationality = "Argentyna",
                            NumberOfMatches = 36,
                            Goals = 7,
                            Assists = 5,
                            Age = 26,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Dominik",
                            Surname = "Szoboszlai",
                            Number = 8,
                            Position = "Pomocnik",
                            Nationality = "Węgry",
                            NumberOfMatches = 34,
                            Goals = 8,
                            Assists = 6,
                            Age = 24,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Harvey",
                            Surname = "Elliott",
                            Number = 19,
                            Position = "Pomocnik",
                            Nationality = "Anglia",
                            NumberOfMatches = 30,
                            Goals = 5,
                            Assists = 5,
                            Age = 21,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Curtis",
                            Surname = "Jones",
                            Number = 17,
                            Position = "Pomocnik",
                            Nationality = "Anglia",
                            NumberOfMatches = 28,
                            Goals = 3,
                            Assists = 2,
                            Age = 23,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Mohamed",
                            Surname = "—",
                            Number = 14,
                            Position = "Napastnik",
                            Nationality = "—",
                            NumberOfMatches = 12,
                            Goals = 2,
                            Assists = 1,
                            Age = 22,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Virgil",
                            Surname = "—",
                            Number = 21,
                            Position = "Obrońca",
                            Nationality = "—",
                            NumberOfMatches = 8,
                            Goals = 0,
                            Assists = 0,
                            Age = 22,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Joe",
                            Surname = "—",
                            Number = 44,
                            Position = "Obrońca",
                            Nationality = "—",
                            NumberOfMatches = 6,
                            Goals = 0,
                            Assists = 0,
                            Age = 21,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Youth",
                            Surname = "Player",
                            Number = 95,
                            Position = "Bramkarz",
                            Nationality = "Anglia",
                            NumberOfMatches = 0,
                            Goals = 0,
                            Assists = 0,
                            Age = 20,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Claude",
                            Surname = "Gonçalves",
                            Number = 5,
                            Position = "Pomocnik",
                            Nationality = "Francja",
                            NumberOfMatches = 20,
                            Goals = 11,             
                            Assists = 4,            
                            Age = 31,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },
                        new Footballer {
                            Name = "Tomáš",
                            Surname = "Pekhart",
                            Number = 7,
                            Position = "Napastnik",
                            Nationality = "Czechy",
                            NumberOfMatches = 16,
                            Goals = 12,            
                            Assists = 1,           
                            Age = 29,
                            Guid = Guid.NewGuid(),
                            IsDeleted = false
                        },

                    };

                    _dbContext.Footballers.AddRange(footballers);
                    await _dbContext.SaveChangesAsync();

                }
            }
        }
    }
}
