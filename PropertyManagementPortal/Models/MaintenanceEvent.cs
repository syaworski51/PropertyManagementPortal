using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a maintenance event.
    /// </summary>
    [Table("MaintenanceEvents")]
    public class MaintenanceEvent
    {
        /// <summary>
        ///     The ID of this maintenance event.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The date of this maintenance event.
        /// </summary>
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        
        /// <summary>
        ///     The ID of the property where this maintenance event took place.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property where this maintenance event took place.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The location on the property where this maintenance event took place.
        ///     Examples: common area, Unit 456, 5th floor
        /// </summary>
        [Display(Name = "Location")]
        public string Location { get; set; }

        /// <summary>
        ///     A brief description of the work done.
        ///     Examples: Changed light bulb, fixed washing machine, etc.
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
