using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;

namespace PropertyManagementPortalAPI.Models
{
    public class Occupant
    {
        public ObjectId Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string FirstName { get; set; }
        public List<string> MiddleNames { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
