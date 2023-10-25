using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionCompanyDB.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public string StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public string EndDate { get; set; }

        [Required]
        [DisplayName("Budget")]
        [DataType(DataType.Currency)]
        public string Budget { get; set; }

        [Required]
        [DisplayName("Project Address")]
        public string ProjectAddress { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        [Required]
        public int ClientID { get; set; }

        [Required]
        public int SubcontractorID { get; set; }


        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public Subcontractor Subcontrctor { get; set; }

    }
}
