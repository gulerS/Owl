using FluentValidation;
using OwlSchool.Application.Features.Classes.Queries.GetByIdClass;

namespace OwlSchool.Application.Features.Classes.Commands.CreateClass;

public class GetByIdClassQueryValidator:AbstractValidator<GetByIdClassQuery>
{
    public GetByIdClassQueryValidator()
    {
        RuleFor(c => c.Id).GreaterThanOrEqualTo(1);
       
    }
}