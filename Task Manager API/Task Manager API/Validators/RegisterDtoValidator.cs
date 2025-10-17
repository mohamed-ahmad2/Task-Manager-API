using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;
using Task_Manager_API.DTOs;

namespace Task_Manager_API.Validators
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required").MaximumLength(100);

            RuleFor(x => x.Email)
            .NotEmpty().EmailAddress().WithMessage("Invalid email format");

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long");
        }
    }
}
