namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public decimal Salary { get; set; }
        public required string AuthCode { get; set; }
    }
}
