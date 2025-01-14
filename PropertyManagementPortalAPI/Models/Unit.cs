using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents a unit available for rent.
    /// </summary>
    [Table("Units")]
    public class Unit
    {
        public ObjectId Id { get; set; }
        
        /// <summary>
        ///     The property this unit belongs to.
        /// </summary>
        public Property Property { get; set; }

        /// <summary>
        ///     The number of this unit.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     The monthly rent for this unit.
        /// </summary>
        [Column(TypeName = "decimal(6,2)")]
        public decimal MonthlyRent { get; set; }

        /// <summary>
        ///     The size of this unit in square feet.
        /// </summary>
        public int UnitSize { get; set; }

        /// <summary>
        ///     The tenant renting this unit. Null if this unit is vacant.
        /// </summary>
        public Tenant Tenant { get; set; }

        /// <summary>
        ///     The current status of this unit (Closed, Available, Occupied).
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     The path to this unit's floor plan image. Null if there is no floor plan available.
        /// </summary>
        public string? FloorPlanPath { get; set; }

        /// <summary>
        ///     A list of the appliances in this unit.
        /// </summary>
        public List<Appliance> Appliances { get; set; }
    }
}
