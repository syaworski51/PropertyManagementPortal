using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PropertyManagementPortalAPI.Interfaces
{
    public interface IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        ObjectId Id { get; set; }
    }
}
