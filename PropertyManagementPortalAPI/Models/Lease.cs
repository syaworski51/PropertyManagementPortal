using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents a lease agreement signed by a tenant and a lease administrator.
    /// </summary>
    [Table("Leases")]
    public class Lease
    {
        public ObjectId Id { get; set; }
        
        /// <summary>
        ///     The status of this lease.
        ///     
        ///     Signed - The lease has been signed, but has not started yet.
        ///     Active - The lease is currently active.
        ///     Expired - The lease has expired.
        ///     Terminated - The lease has been terminated, either by the tenant(s) ending the lease early,
        ///                  or the landlord evicting the tenant(s).
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        ///     The tenants on this lease.
        /// </summary>
        public List<Tenant> Tenants { get; set; }

        /// <summary>
        ///     A list of emergency contacts.
        /// </summary>
        public List<EmergencyContact> EmergencyContacts { get; set; }

        /// <summary>
        ///     The duration of this lease in months. Null if this is a month-to-month lease.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        ///     The type of lease this is (fixed, month-to-month).
        /// </summary>
        public string LeaseType { get; set; }

        /// <summary>
        ///     The start date of this lease.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     The end date of this lease.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        ///     The deadline for renewing this lease.
        /// </summary>
        public DateTime? RenewalDeadline { get; set; }

        /// <summary>
        ///     The monthly rent for this lease.
        /// </summary>
        public decimal MonthlyRent { get; set; }

        /// <summary>
        ///     Any additional fees associated with this lease.
        /// </summary>
        public List<Fee> AdditionalFees { get; set; }

        /// <summary>
        ///     The security deposit for this lease.
        /// </summary>
        public Deposit SecurityDeposit { get; set; }

        /// <summary>
        ///     The property for this lease.
        /// </summary>
        public Property Property { get; set; }

        /// <summary>
        ///     The unit for this lease.
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        ///     The storage unit(s) assigned to the tenant(s) on this lease.
        /// </summary>
        public List<StorageUnit> StorageUnits { get; set; }

        /// <summary>
        ///     The parking spot(s) assigned to the tenant(s) on this lease.
        /// </summary>
        public List<ParkingSpot> ParkingSpots { get; set; }

        /// <summary>
        ///     All the occupants on this lease. Includes the aforementioned tenants and any other adults and minors.
        /// </summary>
        public List<Occupant> Occupants { get; set; }

        /// <summary>
        ///     A chronological log of all the amendments that have been made to this lease.
        ///     
        ///     Examples:
        ///         - Jan 24, 2023: Rent increased from $1500 to $1800.
        ///         - Apr 17, 2023: Pet added to lease ("Baxter", male golden retriever, 2 years old).
        ///         - Aug 08, 2023: Roommate removed from lease ("John Doe", male, 24 years old).
        /// </summary>
        public List<Amendment> Amendments { get; set; }
        
    }
}
