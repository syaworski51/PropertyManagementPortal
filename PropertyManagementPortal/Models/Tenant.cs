using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a tenant renting a unit.
    /// </summary>
    [Table("Tenants")]
    public class Tenant
    {
        /// <summary>
        ///     The ID of this tenant.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The date that this tenant was registered in the database.
        /// </summary>
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     The tenant's first name.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The tenant's last name.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The tenant's full name.
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        ///     The tenant's phone number.
        /// </summary>
        [Display(Name = "Phone #")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     The tenant's email address.
        /// </summary>
        [Display(Name = "Email")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        ///     The status of this tenant.
        ///     Examples: Active, Former, Evicted
        /// </summary>
        [Display(Name = "Status")]
        public string Status { get; set; }

        /// <summary>
        ///     The number of times this tenant was late paying their rent.
        /// </summary>
        [Display(Name = "Late Payments")]
        public int LatePayments { get; set; }
    }
}
