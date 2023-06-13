namespace Rask.Api.Data.Models;

/// <summary>
/// Employee recrod.
/// </summary>
/// <param name="Id">Id of user. Should be a GUID.</param>
/// <param name="FirstName">First name of user.</param>
/// <param name="LastName">Last name of user.</param>
/// <param name="Email">Email address of user. This is also used for logging in.</param>
/// <param name="Phone">Phone number.</param>
/// <param name="Gender">Employee gender. i.e. Male or Female.</param>
/// <param name="StreetAddress">Street address.</param>
/// <param name="City">City.</param>
/// <param name="State">State.</param>
/// <param name="ZipCode">Zip code.</param>
/// <param name="JobTitle">Employee job title.</param>
/// <param name="DepartmentId">Department Id of employee.</param>
/// <param name="DateCreated">Date user was created.</param>
/// <param name="DateModified">Date user was updated.</param>
public record Employee(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    Gender Gender,
    string StreetAddress,
    string City,
    string State,
    string ZipCode,
    string JobTitle,
    Guid DepartmentId,
    DateTime DateCreated,
    DateTime? DateModified) : Entity(Id, DateCreated, DateModified)
{
    public Department Department { get; set; } = null!;
}
