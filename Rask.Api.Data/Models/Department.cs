using System.ComponentModel.DataAnnotations;

namespace Rask.Api.Data.Models;

public record Department() : Entity
{
    [Required]
    public string Name { get; init; } = null!;
    public List<Employee> Employees { get; init; } = new();
}
