using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConstructionCompanyDB.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Job Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("DOB")]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^(((\\+?64\\s*[-\\.\\ ]?[3-9]|\\(?0[3-9]\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{4})|((\\+?64\\s*[-\\.\\(\\ ]?2\\d{1,2}[-\\.\\)\\ ]?|\\(?02\\d{1}\\)?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?\\d{3,5})|((\\+?64\\s*[-\\.\\ ]?[-\\.\\(\\ ]?800[-\\.\\)\\ ]?|[-\\.\\(\\ ]?0800[-\\.\\)\\ ]?)\\s*[-\\.\\ ]?\\d{3}\\s*[-\\.\\ ]?(\\d{2}|\\d{5})))|^$$", ErrorMessage = "Please enter a valid Phone Number")]
        public string Number  { get; set; }

        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Work Days")]
        public string WorkDays { get; set; }

        [Required]
        [DisplayName("Start Time")]
        [DataType(DataType.Time)]
        public string StartTime { get; set; }

        [Required]
        [DisplayName("Break Time")]
        [DataType(DataType.Time)]
        public string BreakTime { get; set; }

        [Required]
        [DisplayName("Finish Time")]
        [DataType(DataType.Time)]
        public string FinishTime { get; set; }
        public ICollection <Project> Projects { get; set; }
        public ICollection <Employee> Employees { get; set; }

    }
}