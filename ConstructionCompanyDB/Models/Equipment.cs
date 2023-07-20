namespace ConstructionCompanyDB.Models
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string Manufacturer { get; set; }
        public string OwnOrRent { get; set; }
        public string EmployeeID { get; set; }
        public Employee Employees { get; set; }
    }
}
