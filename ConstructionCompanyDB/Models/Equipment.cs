using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionCompanyDB.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }

        [Required]
        [DisplayName("Equipment Name")]
        public string EquipmentName { get; set; }

        [Required]
        [DisplayName("Manufacturer Name")]
        public string Manufacturer { get; set; }

        [Required]
        public string OwnOrRent { get; set; }

        [Required]
        public string EmployeeID { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        public Employee Employees { get; set; }
    }
}
