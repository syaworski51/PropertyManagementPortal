using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a pet owned by a tenant.
    /// </summary>
    public class Pet
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public PetAge Age { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        public string? LicenseNumber { get; set; }
    }
}
