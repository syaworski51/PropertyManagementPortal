using MongoDB.Bson;
using PropertyManagementPortalAPI.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace PropertyManagementPortalAPI.Models
{
    /// <summary>
    ///     Represents an employee.
    /// </summary>
    [Table("Employees")]
    public class Employee
    {
        /// <summary>
        ///     The ID of this employee.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        ///     The ID of the property this employee works at.
        /// </summary>
        [ForeignKey(nameof(Property))]
        public Guid PropertyId { get; set; }

        /// <summary>
        ///     The property this employee works at.
        /// </summary>
        [Display(Name = "Property")]
        public Property Property { get; set; }

        /// <summary>
        ///     The employee's first name.
        /// </summary>
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The employee's last name.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        ///     The employee's full name.
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        ///     The date this employee was registered in the database.
        /// </summary>
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        ///     The date this employee began their employment.
        /// </summary>
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     The date this employee's employment ended, or will end.
        ///     Null if this employee has not tendered their resignation with a specified end date,
        ///     or has not been terminated.
        /// </summary>
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        ///     This employee's position.
        ///     Examples: Maintenance worker, Administrator, Leasing Specialist
        /// </summary>
        [Display(Name = "Position")]
        public string Position { get; set; }

        /// <summary>
        ///     The wage this employee is paid.
        /// </summary>
        [Display(Name = "Wage")]
        public decimal Wage { get; set; }

        /// <summary>
        ///     The unit of time this employee is paid by.
        /// </summary>
        [Display(Name = "per")]
        public string PerUnitOfTime { get; set; }

        /// <summary>
        ///     The wage this employee is paid, represented in a string.
        /// </summary>
        [Display(Name = "Wage")]
        public string WageString => string.Format("{0:C2}/{1}", Wage, PerUnitOfTime);

        
    }
}