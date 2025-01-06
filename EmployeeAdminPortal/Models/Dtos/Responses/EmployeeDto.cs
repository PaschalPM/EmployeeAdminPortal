namespace EmployeeAdminPortal.Models.Dtos.Responses
{
    public class EmployeeDto
    {
        public Guid id { get; set; }
        public required string Name { get; set; }
        public required string EmailAddress { get; set; }
        public required string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
