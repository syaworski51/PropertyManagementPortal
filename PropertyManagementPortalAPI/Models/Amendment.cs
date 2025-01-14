namespace PropertyManagementPortalAPI.Models
{
    public class Amendment
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }


        public override string ToString()
        {
            return $"{Date:MMM dd, yyyy}: {Description}";
        }
    }
}
