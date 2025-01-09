using Microsoft.VisualBasic;
using Moq;
using MovieStoreC.BL.Services;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.DTO;
using System.Xml.Linq;

namespace MovieStoreC.Tests
{
    public class BusinessServiceUnitTests
    {
        private readonly Mock<IMovieRepository> _movieRepositoryMock;
        private readonly Mock<IActorRepository> _actorRepositoryMock;


        private List<Actor> _actors = new List<Actor>();
        {
            new Actor()
            {
            Id = "0ee7dd7b-26da-492a-9874-977b4f818e27";
            Name = "Actor 1";
            }
            new Actor()
            {
                Id = "b14f534c-cd36-472d-8726-498ec1b19020";
                Name = "Actor 2";
            }
            new Actor()
            {
                Id = "c3290ce5-15a9-46da-a2aa-b53090fa7642";
                Name = "Actor 3";
            }        
        }

        private List<Movie> _movies = new List<Movie>();
        {
            new Movie()
        {
        Id = 1;
        Title = "Movie 1";
        Year = 2014;
        Actors = ["0ee7dd7b-26da-492a-9874-977b4f818e27"];

        new Movie()
        {
            Id = 2;
            Title = "Movie 2";
            Year = 2015;
            Actors = ["0ee7dd7b-26da-492a-9874-977b4f818e27,   b14f534c-cd36-472d-8726-498ec1b19020"];
        }
         new Movie()
        {
        Id = 3;
        Title = "Movie 3";
        Year = 2016;
        Actors = ["0ee7dd7b-26da-492a-9874-977b4f818e27,   c3290ce5-15a9-46da-a2aa-b53090fa7642"];
        }

    }
    
}

public BusinessServiceUnitTests()
        {
            _movieRepositoryMock = new Mock<IMovieRepository> ();
            _actorRepositoryMock = new Mock<IActorRepository>();
        }

        [Fact]
        public void GetAllMovies_Ok()
        {
            //setup
            var expectedCount = 2;


            //inject
            var businessService = new BusinessService(_movieRepositoryMock, _actorRepositoryMock);
        }


    }
}