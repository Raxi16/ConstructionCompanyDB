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
        public int EmployeeID { get; set; }
        public int ClientID { get; set; }
        public int SubcontractorID { get; set; }


        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public Subcontractor Subcontrctor { get; set; }

    }
}
