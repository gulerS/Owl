using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Features.Classes.Rules;

public class ClassBusinessRules
{
    private readonly IClassRepository _classRepository;

    public ClassBusinessRules(IClassRepository classRepository)
    {
        _classRepository = classRepository;
    }

    public async Task ClassNameCanNotBeDuplicatedWhenInserted(string name)
    {
        IPaginate<Class> result = await _classRepository.GetListAsync(b => b.Name == name);
        if (result.Items.Any()) throw new BusinessException("Class name exists.");
    }

    public void ClassShouldExistWhenRequested(Class classs)
    {
        if (classs == null) throw new BusinessException("Requested class does not exist");
    }
}
