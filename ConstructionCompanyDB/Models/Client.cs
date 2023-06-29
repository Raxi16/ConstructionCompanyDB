namespace ConstructionCompanyDB.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string  ContactNumber{ get; set; }
        public string Email { get; set; }
        public ICollection<Project>Projects { get; set; }
    }
}
