using Application;
using Domain.Persons;
using Microsoft.EntityFrameworkCore;

namespace Persistance;

public class Database : DbContext, IDatabase
{
    public Database(DbContextOptions<Database> options)
       : base(options)
    {
        FillPersonTable();
    }

    private void FillPersonTable()
    {
        Persons.Add(new Person { Age = 20, Name = "John", Surname = "Doe", Id = 1 });
        Persons.Add(new Person { Age = 30, Name = "Jane", Surname = "Doe", Id = 2 });
        Persons.Add(new Person { Age = 40, Name = "Jack", Surname = "Doe", Id = 3 });
        SaveChanges();
    }

    public DbSet<Person> Persons { get; set; }
}
