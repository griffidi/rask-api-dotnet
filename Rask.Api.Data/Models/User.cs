namespace Rask.Api.Data.Models;

/// <summary>
/// User record.
/// </summary>
/// <param name="Id">Id of user. Should be a GUID.</param>
/// <param name="UserName">User name of user.</param>
/// <param name="FirstName">First name of user.</param>
/// <param name="LastName">Last name of user.</param>
/// <param name="Email">Email address of user. This is also used for logging in.</param>
/// <param name="DateCreated">Date user was created.</param>
/// <param name="DateModified">Date user was updated.</param>
public record User(
    Guid Id,
    string UserName,
    string FirstName,
    string LastName,
    string Email,
    DateTime DateCreated,
    DateTime? DateModified) : Entity(Id, DateCreated, DateModified);
