namespace ConstructionCompanyDB.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string  Number{ get; set; }
        public string Email { get; set; }
        public ICollection<Project>Projects { get; set; }
    }
}
