namespace ConstructionCompanyDB.Models
{
    public class Subcontractor
    {
        public int SubcontractorID { get; set; }
        public string Name { get; set; }
        public string JobName { get; set; }
        public string Number { get; set; }
        public string email { get; set; }
        public ICollection <Employee> Employees { get; set; }
    }
}