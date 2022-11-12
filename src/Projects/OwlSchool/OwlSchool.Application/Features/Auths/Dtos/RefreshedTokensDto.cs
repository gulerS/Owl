using Core.Security.Entities;
using Core.Security.JWT;

namespace OwlSchool.Application.Features.Auths.Dtos;

public class RefreshedTokensDto
{
    public AccessToken AccessToken { get; set; }
    public RefreshToken RefreshToken { get; set; }
}