using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;

namespace PropertyManagementPortalAPI.Models
{
    public class StorageUnit
    {
        public ObjectId Id { get; set; }
        
        /// <summary>
        ///     The number of this storage unit.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     The tenant occupying this storage unit. Null if it is vacant.
        /// </summary>
        public Tenant? Tenant { get; set; }

        /// <summary>
        ///     The status of this storage unit.
        ///     
        ///     Available - This unit is vacant and does not have a tenant assigned to it.
        ///     Occupied - This unit has a tenant assigned to it.
        ///     Overlock - The tenant is late paying their storage fees, and access to this unit will be blocked
        ///                until the fees are paid.
        /// </summary>
        public string Status { get; set; }
    }
}
