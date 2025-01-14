using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents an amenity that can be offered at a rental property.
    /// </summary>
    [Table("Amenities")]
    public class Amenity
    {
        /// <summary>
        ///     The ID of this amenity.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The date this amenity was created.
        /// </summary>
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     The title of this amenity.
        ///     Examples: Fitness room, in-unit laundry, underground parking, etc.
        /// </summary>
        [Display(Name = "Description")]
        public string Title { get; set; }
        
    }
}
