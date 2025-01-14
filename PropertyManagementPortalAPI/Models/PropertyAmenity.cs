using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents an amenity offered at a property.
    /// </summary>
    [Table("PropertyAmenities")]
    public class PropertyAmenity
    {
        /// <summary>
        ///     The ID of this amenity.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property this amenity is offered at.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this amenity is offered at.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the amenity offered at this property.
        /// </summary>
        [ForeignKey(nameof(Amenity))]
        public Guid AmenityId { get; set; }

        /// <summary>
        ///     The amenity offered at this property.
        /// </summary>
        [Display(Name = "Amenity")]
        public Amenity Amenity { get; set; }
    }
}
