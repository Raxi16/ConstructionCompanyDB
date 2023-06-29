namespace ConstructionCompanyDB.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Budget { get; set; } 
        public string ProjectAddress { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public Employee Employee { get; set; }
        public Client Client { get; set; }

    }
}
