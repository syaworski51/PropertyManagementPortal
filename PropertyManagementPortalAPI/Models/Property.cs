using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents a property with units available for rent.
    /// </summary>
    public class Property
    {
        /// <summary>
        ///     The unique ID of this property.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        
        /// <summary>
        ///     The type of property this is (house, apartment).
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        ///     The name of this property (ex. Barkley Towers, The Empress, Queensbury Court, etc.).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     A description of this property.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     The street address of this property.
        /// </summary>
        public StreetAddress Address { get; set; }

        /// <summary>
        ///     The phone numbers of this property.
        /// </summary>
        public List<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        ///     The email addresses of this property.
        /// </summary>
        public List<EmailAddress> EmailAddresses { get; set; }

        /// <summary>
        ///     Whether this property allows pets or not.
        /// </summary>
        public bool PetsAllowed { get; set; }

        /// <summary>
        ///     A list of images of this property.
        /// </summary>
        public List<Image> Images { get; set; }
        
        /// <summary>
        ///     A list of amenities this property offers (ex. gym, media room, underground parking, etc.).
        /// </summary>
        public List<Amenity> Amenities { get; set; }
    }
}
