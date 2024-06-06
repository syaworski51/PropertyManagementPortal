using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents an animal companion owned by a tenant.
    /// </summary>
    [Table("Pets")]
    public class Pet
    {
        /// <summary>
        ///     The ID of this pet.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property where this pet lives.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property where this pet lives.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the tenant that owns this pet.
        /// </summary>
        [ForeignKey(nameof(Tenant))]
        public Guid TenantId { get; set; }

        /// <summary>
        ///     The tenant that owns this pet.
        /// </summary>
        [Display(Name = "Tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        ///     The date that the tenant brought this pet to the property to live with them.
        /// </summary>
        [Display(Name = "Date of Arrival")]
        public DateTime DateOfArrival { get; set; }

        /// <summary>
        ///     The date that this pet died. Null if this pet is alive.
        /// </summary>
        [Display(Name = "Date of Death")]
        public DateTime? DateOfDeath { get; set; }

        /// <summary>
        ///     The type of pet this is (dog, cat).
        /// </summary>
        [Display(Name = "Type")]
        public string Type { get; set; }

        /// <summary>
        ///     The breed of dog or cat this pet is.
        /// </summary>
        [Display(Name = "Breed")]
        public string Breed { get; set; }

        /// <summary>
        ///     The name of this pet.
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
