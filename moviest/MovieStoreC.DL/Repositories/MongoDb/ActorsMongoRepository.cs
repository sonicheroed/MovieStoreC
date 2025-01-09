using DnsClient.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStoreC.DL.Interfaces;
using MovieStoreC.Models.Configurations;
using MovieStoreC.Models.DTO;

namespace MovieStoreC.DL.Repositories.MongoDb
{
    internal class ActorsMongoRepository : IMovieRepository
    {
        private readonly IMongoCollection<Actor> _moviesCollection;
        private readonly ILogger<ActorsMongoRepository> _logger;

        public ActorsMongoRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<ActorsMongoRepository> logger)
        {
            _logger = logger;

            var client =
                new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(
                mongoConfig.CurrentValue.DatabaseName);
            _moviesCollection = database.GetCollection<Actor>("MoviesDb");
        }

        public List<Actor> GetAll()
        {
            return _moviesCollection.Find(m => true)
                .ToList();
        }

        public Actor? GetById(string id)
        {
            throw new NotImplementedException();
        }

        List<Movie> IMovieRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Movie? IMovieRepository.GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
