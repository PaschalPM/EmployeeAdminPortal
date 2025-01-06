namespace EmployeeAdminPortal.Models.Dtos.Requests
{
    public class CreateEmployeeDto
    {
        public required string Name { get; set; }
        public required string EmailAddress { get; set; }
        public required string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }

}
