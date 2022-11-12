using Core.Persistence.Paging;
using OwlSchool.Application.Features.Users.Dtos;

namespace OwlSchool.Application.Features.Users.Models;

public class UserListModel : BasePageableModel
{
    public IList<UserListDto> Items { get; set; }
}