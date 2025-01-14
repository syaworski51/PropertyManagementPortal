using MongoDB.Driver;

namespace PropertyManagementPortalAPI.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration config)
        {
            bool environmentIsLive = false;
            var dbInfo = config.GetSection("APISecrets:MongoDB");
            dbInfo = dbInfo.GetSection(environmentIsLive ? "Live" : "Local");
            
            var connectionString = dbInfo["ConnectionString"];
            var database = dbInfo["Database"];

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(database);
        }

        /// <summary>
        ///     Get a collection from the database.
        /// </summary>
        /// <typeparam name="T">The type of the collection.</typeparam>
        /// <param name="name">The name of the specific collection.</param>
        /// <returns>The specific collection from the database.</returns>
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return _database.GetCollection<T>(name);
        }
    }
}
