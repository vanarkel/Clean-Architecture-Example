using Domain.Persons;
using Microsoft.EntityFrameworkCore;

namespace Application.Persons
{

    public class PersonQuery : IPersonQuery
    {
        private readonly IDatabase _database;

        public PersonQuery(IDatabase database)
        {
            _database = database;
        }
        public async Task<IEnumerable<PersonModel>> GetAllAsync()
        {

            return await _database.Persons.Select( x => new PersonModel
            {
                Age = x.Age,
                Name = x.Name,
                Surname = x.Surname,
                Id = x.Id

            }).ToListAsync();
        }
    }
}