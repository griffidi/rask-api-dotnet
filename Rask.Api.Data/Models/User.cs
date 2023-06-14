using System.ComponentModel.DataAnnotations;

namespace Rask.Api.Data.Models;

public record User() : Entity
{
    [Required]
    public string UserName { get; init; } = null!;
    [Required]
    public string FirstName { get; init; } = null!;
    [Required]
    public string LastName { get; init; } = null!;
    [Required]
    public string Email { get; init; } = null!;
}
