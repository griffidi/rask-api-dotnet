using System.ComponentModel.DataAnnotations;

namespace Rask.Api.Data.Models;

public abstract record Entity()
{
    [Key]
    public Guid Id { get; init; }
    [Required]
    public DateTime DateCreated { get; init; }
    public DateTime? DateModified { get; init; }
}
