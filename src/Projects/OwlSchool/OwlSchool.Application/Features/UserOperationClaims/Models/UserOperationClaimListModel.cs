using Core.Persistence.Paging;
using OwlSchool.Application.Features.UserOperationClaims.Dtos;

namespace OwlSchool.Application.Features.UserOperationClaims.Models;

public class UserOperationClaimListModel : BasePageableModel
{
    public IList<UserOperationClaimListDto> Items { get; set; }
}