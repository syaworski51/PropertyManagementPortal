using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a unit available for rent.
    /// </summary>
    [Table("Units")]
    public class Unit
    {
        /// <summary>
        ///     The ID of this unit.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property this unit belongs to.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this unit belongs to.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The number of this unit.
        /// </summary>
        [Display(Name = "Unit #")]
        public string Number { get; set; }

        /// <summary>
        ///     The monthly rent for this unit.
        /// </summary>
        [Display(Name = "Monthly Rent")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal MonthlyRent { get; set; }

        /// <summary>
        ///     The monthly rent for this unit, represented in a string.
        /// </summary>
        [Display(Name = "Monthly Rent")]
        public string MonthlyRentString => $"${MonthlyRent}/month";

        /// <summary>
        ///     The ID of the tenant renting this unit. Null if this unit is vacant.
        /// </summary>
        [ForeignKey(nameof(Tenant))]
        public Guid? TenantId { get; set; }

        /// <summary>
        ///     The tenant renting this unit. Null if this unit is vacant.
        /// </summary>
        [Display(Name = "Tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        ///     The current status of this unit (Closed, Available, Occupied).
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     The path to this unit's floor plan image. Null if there is no floor plan available.
        /// </summary>
        public string? FloorPlanPath { get; set; }
    }
}
