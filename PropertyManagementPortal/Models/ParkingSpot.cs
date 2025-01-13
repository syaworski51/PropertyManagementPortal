namespace PropertyManagementPortal.Models
{
    public class ParkingSpot
    {
        /// <summary>
        ///     The number of this parking spot.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        ///     The tenant that has been assigned to this parking spot. Null if there is no tenant assigned to this spot.
        /// </summary>
        public Tenant? Tenant { get; set; }

        /// <summary>
        ///     The status of this parking spot (Available, Occupied).
        /// </summary>
        public string Status { get; set; }
    }
}
