using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents a payment made by a tenant.
    /// </summary>
    [Table("TenantPayments")]
    public class TenantPayment
    {
        /// <summary>
        ///     The ID of this payment.
        /// </summary>
        [Key]
        public ObjectId Id { get; set; }

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
        ///     The nit this payment is being made for.
        /// </summary>
        [Display(Name = "Unit")]
        public Unit Unit { get; set; }

        /// <summary>
        ///     The ID of the tenant that is making this payment.
        /// </summary>
        [ForeignKey(nameof(Tenant))]
        public Guid TenantId { get; set; }

        /// <summary>
        ///     The tenant that is making this payment.
        /// </summary>
        [Display(Name = "Tenant")]
        public Tenant Tenant { get; set; }


        /// <summary>
        ///     The date this payment was made.
        /// </summary>
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     The ID of the payment item that is being paid for.
        /// </summary>
        [ForeignKey(nameof(PaymentItem))]
        public Guid PaymentItemId { get; set; }

        /// <summary>
        ///     The ID of the payment item that is being paid for.
        /// </summary>
        [Display(Name = "Payment Item")]
        public PaymentItem PaymentItem { get; set; }

        /// <summary>
        ///     The payment item that is being paid for.
        /// </summary>
        [Display(Name = "Amount Paid")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal AmountPaid { get; set; }

        /// <summary>
        ///     The method of payment.
        ///     Examples: Debit/credit card, Online banking, Cheque, Cash
        /// </summary>
        [Display(Name = "Method")]
        public string Method { get; set; }
    }
}
