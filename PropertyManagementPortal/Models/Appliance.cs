using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents an appliance, such as a fridge, oven, washing maching, dryer, etc.
    /// </summary>
    [Table("Appliances")]
    public class Appliance
    {
        /// <summary>
        ///     The ID of this appliance.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property this appliance belongs to.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this appliance belongs to.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The ID of the unit this appliance belongs to.
        ///     Null if this appliance is in a common area (ex. coin-op washing machine/dryer).
        /// </summary>
        [ForeignKey(nameof(Unit))]
        public Guid? UnitId { get; set; }

        /// <summary>
        ///     The unit this appliance belongs to.
        ///     Null if this appliance is in a common area (ex. coin-op washing machine/dryer).
        /// </summary>
        [Display(Name = "Unit")]
        public Unit? Unit { get; set; }

        /// <summary>
        ///     A description of this appliance. Includes the manufacturer, model name, and capacity (if applicable).
        ///     Example: "Frigidaire Stainless Steel Top-Freezer Refrigerator (18.3 cu. ft.) - FFTR1835VS"
        ///     https://www.leons.ca/products/frigidaire-stainless-steel-top-freezer-refrigerator-183-cu-ft-fftr1835vs
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        ///     The price of this appliance.
        /// </summary>
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

        /// <summary>
        ///     The date this appliance was purchased.
        /// </summary>
        [Display(Name = "Purchased on")]
        public DateTime DatePurchased { get; set; }

        /// <summary>
        ///     The date this appliance was installed. Null if this appliance hasn't been installed yet.
        /// </summary>
        [Display(Name = "Installed on")]
        public DateTime? DateInstalled { get; set; }

        /// <summary>
        ///     The duration of the warranty on this appliance (12 months, 5 years).
        /// </summary>
        [Display(Name = "Warranty")]
        public int WarrantyDuration { get; set; }

        /// <summary>
        ///     The unit of time for the warranty on this appliance (months, years).
        /// </summary>
        [Display(Name = "Unit of Time")]
        public string UnitOfTime { get; set; }

        /// <summary>
        ///     The date that the warranty expires. Determined by the date of purchase.
        /// </summary>
        [Display(Name = "Warranty Expiry")]
        public DateTime WarrantyExpiry { get; set; }
    }
}
