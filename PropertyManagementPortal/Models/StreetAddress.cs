using System.ComponentModel.DataAnnotations;

namespace PropertyManagementPortal.Models
{
    public class StreetAddress
    {
        public string Address { get; set; }
        
        public string City { get; set; }

        [MaxLength(2)]
        public string Province { get; set; }
        
        public string Country { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }


        public override string ToString()
        {
            return $"{Address}, {City}, {Province}, {PostalCode}";
        }
    }
}
