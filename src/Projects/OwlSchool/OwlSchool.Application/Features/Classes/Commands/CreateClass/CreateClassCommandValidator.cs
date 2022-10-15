using FluentValidation;

namespace OwlSchool.Application.Features.Classes.Commands.CreateClass;

public class CreateClassCommandValidator:AbstractValidator<CreateClassCommand>
{
    public CreateClassCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Name).MinimumLength(2);
        RuleFor(c => c.Floor).GreaterThanOrEqualTo(1);
    }
}