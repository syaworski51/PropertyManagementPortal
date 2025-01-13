using MongoDB.Driver;
using System.Net.Http.Headers;

namespace PropertyManagementPortal.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var dbInfo = configuration.GetSection("Secrets:MongoDB");
            var connectionString = dbInfo["Connection"];
            var name = dbInfo["DBName"];

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(name);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
