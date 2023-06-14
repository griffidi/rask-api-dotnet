using System.ComponentModel.DataAnnotations;

namespace Rask.Api.Data.Models;

public record Employee() : Entity
{
    [Required]
    public string FirstName { get; init; } = null!;
    [Required]
    public string LastName { get; init; } = null!;
    [Required]
    public string Email { get; init; } = null!;
    [Required]
    public string Phone { get; init; } = null!;
    [Required]
    public Gender Gender { get; init; }
    [Required]
    public string StreetAddress { get; init; } = null!;
    [Required]
    public string City { get; init; } = null!;
    [Required]
    public string State { get; init; } = null!;
    [Required]
    public string ZipCode { get; init; } = null!;
    [Required]
    public string JobTitle { get; init; } = null!;
    [Required]
    public Guid DepartmentId { get; init; }
    public Department Department { get; set; } = null!;
}
