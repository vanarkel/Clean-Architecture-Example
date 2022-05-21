using System;
using System.Collections.Generic;
using System.Linq;
using Application;
using Application.Persons;
using AutoFixture;
using AutoFixture.AutoMoq;
using Domain.Persons;
using Microsoft.EntityFrameworkCore;
using Moq;
using Persistance;
using Xunit;

namespace Application.Test
{
    public class GetPersonListQueryTest
    {

        [Fact]
        public void ShouldGetPersonListQuery()
        {
            var database = new Database(new DbContextOptionsBuilder<Database>().UseInMemoryDatabase(databaseName: "Persons").Options);
            var query = new PersonQuery(database);

            var result = query.GetAllAsync();

            Assert.NotNull(result.Result);
        }
    }
}