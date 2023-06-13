namespace Rask.Api.Data.Models;

/// <summary>
/// Entity base record.
/// </summary>
/// <param name="Id">ID from entity. Should be a GUID.</param>
/// <param name="DateCreated">Date user was created.</param>
/// <param name="DateModified">Date user was updated.</param>
public abstract record Entity(Guid Id, DateTime DateCreated, DateTime? DateModified);
