using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a payment that a tenant is responsible for rendering.
    /// </summary>
    [Table("PaymentItems")]
    public class PaymentItem
    {
        /// <summary>
        ///     The ID of this payment item.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property this payment is being made at.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this payment is being made at.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the unit this payment is being made for.
        /// </summary>
        [ForeignKey(nameof(Unit))]
        public Guid UnitId { get; set; }

        /// <summary>
        ///     The unit this payment is being made for.
        /// </summary>
        [Display(Name = "Unit")]
        public Unit Unit { get; set; }

        /// <summary>
        ///     The ID of the tenant responsible for making this payment.
        /// </summary>
        [ForeignKey(nameof(Tenant))]
        public Guid TenantId { get; set; }

        /// <summary>
        ///     The tenant responsible for making this payment.
        /// </summary>
        [Display(Name = "Tenant")]
        public Tenant Tenant { get; set; }



        /// <summary>
        ///     The date this payment item was created. Typically created automatically, such as after a lease is signed, 
        ///     or after rent is paid.
        /// </summary>
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     The date that this payment item must be paid by.
        /// </summary>
        [Display(Name = "Deadline")]
        public DateTime Deadline { get; set; }

        /// <summary>
        ///     The date that this item was paid.
        ///     Null if this item has not been paid yet.
        /// </summary>
        [Display(Name = "Date Paid")]
        public DateTime? DatePaid { get; set; }

        /// <summary>
        ///     A brief description of this payment item.
        ///     Examples: Deposit, Rent, Damages
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        ///     The amount of money to be paid.
        /// </summary>
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }

        /// <summary>
        ///     The status of this payment item.
        ///     Examples: Pending, Paid, Late, Paid late
        /// </summary>
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
