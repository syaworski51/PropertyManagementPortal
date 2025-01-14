using MongoDB.Bson;
using MongoDB.Driver;
using PropertyManagementPortalAPI.Data;
using PropertyManagementPortalAPI.Interfaces;

namespace PropertyManagementPortalAPI.Services
{
    public class MongoCollectionService<TEntity>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public MongoCollectionService(IMongoClient client, string databaseName, string collectionName)
        {
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<TEntity>(collectionName);
        }

        public async Task CreateAsync(TEntity document) =>
            await _collection.InsertOneAsync(document);

        public async Task<List<TEntity>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task<TEntity> GetByIdAsync(ObjectId id) =>
            await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();

        public async Task UpdateAsync(ObjectId id, TEntity updatedDocument) =>
            await _collection.ReplaceOneAsync(e => e.Id == id, updatedDocument);

        public async Task DeleteAsync(ObjectId id) =>
            await _collection.DeleteOneAsync(e => e.Id == id);
    }
}
