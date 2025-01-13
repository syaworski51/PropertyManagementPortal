namespace PropertyManagementPortal.Models
{
    public class Occupant
    {
        public DateTime DateCreated { get; set; }
        public string FirstName { get; set; }
        public List<string> MiddleNames { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
