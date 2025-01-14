using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents an appliance, such as a fridge, oven, washing maching, dryer, etc.
    /// </summary>
    [Table("Appliances")]
    public class Appliance
    {
        public ObjectId Id { get; set; }
        
        /// <summary>
        ///     The property this appliance belongs to.
        /// </summary>
        public Property Property { get; set; }

        /// <summary>
        ///     The unit this appliance belongs to.
        ///     Null if this appliance is in a common area (ex. coin-op washing machine/dryer).
        /// </summary>
        public Unit? Unit { get; set; }

        /// <summary>
        ///     A description of this appliance. Includes the manufacturer, model name, and capacity (if applicable).
        ///     Example: "Frigidaire Stainless Steel Top-Freezer Refrigerator (18.3 cu. ft.) - FFTR1835VS"
        ///     https://www.leons.ca/products/frigidaire-stainless-steel-top-freezer-refrigerator-183-cu-ft-fftr1835vs
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     The serial number of this appliance.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        ///     The price of this appliance.
        /// </summary>
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        /// <summary>
        ///     The date this appliance was purchased.
        /// </summary>
        public DateTime DatePurchased { get; set; }

        /// <summary>
        ///     The date this appliance was installed. Null if this appliance hasn't been installed yet.
        /// </summary>
        public DateTime? DateInstalled { get; set; }

        /// <summary>
        ///     The duration of the warranty on this appliance (12 months, 5 years).
        /// </summary>
        public int WarrantyDuration { get; set; }

        /// <summary>
        ///     The unit of time for the warranty on this appliance (months, years).
        /// </summary>
        public string UnitOfTime { get; set; }

        /// <summary>
        ///     The date that the warranty expires. Determined by the date of purchase.
        /// </summary>
        public DateTime WarrantyExpiryDate { get; set; }
        public ObjectId Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
