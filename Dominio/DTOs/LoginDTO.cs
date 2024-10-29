using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MinimalApi.DTOs;

public class LoginDTO
{
    public required string Email { get; set; }
    public string? Senha { get; set; } = default;
}