namespace Rask.Api.Data.Models;

/// <summary>
/// Department recrod.
/// </summary>
/// <param name="Id">Id of user. Should be a GUID.</param>
/// <param name="Name">Department name.</param>
/// <param name="DateCreated">Date user was created.</param>
/// <param name="DateModified">Date user was updated.</param>
public record Department(
    Guid Id,
    string Name,
    DateTime DateCreated,
    DateTime? DateModified) : Entity(Id, DateCreated, DateModified)
{
    public List<Employee> Employees { get; init; } = new();
}
