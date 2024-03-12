using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a lease agreement signed by a tenant and a lease administrator.
    /// </summary>
    [Table("Leases")]
    public class Lease
    {
        /// <summary>
        ///     The ID of this lease agreement.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property where the tenant is renting a unit.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property where the tenant is renting a unit.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the unit the tenant is renting.
        /// </summary>
        [ForeignKey(nameof(Unit))]
        public Guid UnitId { get; set; }

        /// <summary>
        ///     The unit the tenant is renting.
        /// </summary>
        [Display(Name = "Unit")]
        public Unit Unit { get; set; }


        /// <summary>
        ///     The ID of the lease administrator signing this lease.
        /// </summary>
        [ForeignKey(nameof(LeaseAdmin))]
        public Guid LeaseAdminId { get; set; }

        /// <summary>
        ///     The lease administrator signing this lease.
        /// </summary>
        [Display(Name = "Lease Admin")]
        public Employee LeaseAdmin { get; set; }

        /// <summary>
        ///     Has the lease administrator signed this lease?
        /// </summary>
        [Display(Name = "Signed by L.A.?")]
        public bool LeaseAdminSignature { get; set; }

        /// <summary>
        ///     The date the lease administrator signed this lease.
        ///     Null if the lease administrator has not yet signed this lease.
        /// </summary>
        [Display(Name = "Date of L.A. Sign.")]
        public DateTime? DateOfLeaseAdminSignature { get; set; }

        
        /// <summary>
        ///     The ID of the tenant signing this lease.
        /// </summary>
        [ForeignKey(nameof(Tenant))]
        public Guid TenantId { get; set; }

        /// <summary>
        ///     The tenant signing this lease.
        /// </summary>
        [Display(Name = "Tenant")]
        public Tenant Tenant { get; set; }

        /// <summary>
        ///     Has the tenant signed this lease?
        /// </summary>
        [Display(Name = "Signed by tenant?")]
        public bool TenantSignature { get; set; }

        /// <summary>
        ///     The date the tenant signed this lease.
        ///     Null if the tenant has not yet signed this lease.
        /// </summary>
        [Display(Name = "Date of Tenant Sign.")]
        public DateTime? DateOfTenantSignature { get; set; }


        /// <summary>
        ///     The link that can be used to download a copy of this lease agreement.
        /// </summary>
        [Display(Name = "Download URL")]
        public string DownloadURL { get; set; }
    }
}
