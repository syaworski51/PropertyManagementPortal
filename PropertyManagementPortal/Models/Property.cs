using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace PropertyManagementPortal.Models
{
    /// <summary>
    ///     Represents a property with units available for rent.
    /// </summary>
    [Table("Properties")]
    public class Property
    {
        /// <summary>
        ///     The ID of this property.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The type of property this is (apartment, house).
        /// </summary>
        [Display(Name = "Type")]
        public string Type { get; set; }

        /// <summary>
        ///     The name of this property (ex. Barkley Towers, The Empress, Queensbury Court, etc.).
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        ///     The street address of this property (ex. 123 Main St.).
        /// </summary>
        [Display(Name = "Address")]
        public string Address { get; set; }


        /// <summary>
        ///     The city where this property is located.
        /// </summary>
        [Display(Name = "City")]
        public string City { get; set; }

        /// <summary>
        ///     The province, state, or other regional division where this property is located.
        /// </summary>
        [Display(Name = "Prov./State")]
        public string Division { get; set; }

        /// <summary>
        ///     The country where this property is located.
        /// </summary>
        [Display(Name = "Country")]
        public string Country { get; set; }

        /// <summary>
        ///     This location's postal code.
        /// </summary>
        [Display(Name = "Postal/ZIP Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        /// <summary>
        ///     This location's phone number.
        /// </summary>
        [Display(Name = "Phone #")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     This location's email address.
        /// </summary>
        [Display(Name = "Email")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        ///     Whether this property allows pets or not.
        /// </summary>
        [Display(Name = "Pets Allowed?")]
        public bool PetsAllowed { get; set; }
    }
}
