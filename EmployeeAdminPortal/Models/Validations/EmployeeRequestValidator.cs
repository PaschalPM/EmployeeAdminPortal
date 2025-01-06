using EmployeeAdminPortal.Models.Dtos.Requests;
using FluentValidation;

namespace EmployeeAdminPortal.Models.Validations
{
    public class EmployeeRequestValidator : AbstractValidator<CreateEmployeeDto>
    {
        public EmployeeRequestValidator()
        {
            RuleFor(employee => employee.Name)
           .NotEmpty().WithMessage("Name is required.")
           .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

            RuleFor(employee => employee.EmailAddress)
                .NotEmpty().WithMessage("Email address is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(employee => employee.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number format.");

            RuleFor(employee => employee.Salary)
                .GreaterThan(0).WithMessage("Salary must be greater than 0.");

        }
    }
}
