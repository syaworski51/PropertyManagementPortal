using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents an image of a property, or a unit of a property.
    /// </summary>
    [Table("Images")]
    public class Image
    {
        /// <summary>
        ///     The ID of this image.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The date that this image was uploaded.
        /// </summary>
        [Display(Name = "Date Uploaded")]
        public DateTime DateUploaded { get; set; }

        /// <summary>
        ///     The ID of the property this image belongs to.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this image belongs to.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the unit this image belongs to. Null if this not an image of a unit.
        /// </summary>
        [ForeignKey(nameof(Unit))]
        public Guid? UnitId { get; set; }

        /// <summary>
        ///     The unit this image belongs to. Null if this is not an image of a unit.
        /// </summary>
        [Display(Name = "Unit")]
        public Unit? Unit { get; set; }

        /// <summary>
        ///     A brief caption describing this image. Optional.
        /// </summary>
        [Display(Name = "Caption")]
        public string? Caption { get; set; }

        /// <summary>
        ///     The path to this image in the file server.
        /// </summary>
        [Display(Name = "Path")]
        public string Path { get; set; }
    }
}
