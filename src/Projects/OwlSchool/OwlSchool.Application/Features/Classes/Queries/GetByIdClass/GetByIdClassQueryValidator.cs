using FluentValidation;

namespace OwlSchool.Application.Features.Classes.Queries.GetByIdClass;

public class GetByIdClassQueryValidator:AbstractValidator<GetByIdClassQuery>
{
    public GetByIdClassQueryValidator()
    {
        RuleFor(c => c.Id).GreaterThanOrEqualTo(1);
       
    }
}