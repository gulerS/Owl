using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions;

public class AuthorizationProblemDetails: ProblemDetails
{
    public override string ToString() => JsonSerializer.Serialize(this);
}