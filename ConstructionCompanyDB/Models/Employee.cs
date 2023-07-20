namespace ConstructionCompanyDB.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string Number  { get; set; }
        public string Email { get; set; }
        public string WorkDays { get; set; }
        public string StartTime { get; set; }
        public string BreakTime { get; set; }
        public string FinishTime { get; set; }
        public ICollection <Project> Projects { get; set; }
        public ICollection <Employee> Employees { get; set; }

    }
}