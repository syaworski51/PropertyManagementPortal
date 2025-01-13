using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a tenant renting a unit.
    /// </summary>
    public class Tenant : Occupant
    {
        public string Status { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
