using HotChocolate.Types;
using Rask.Api.Data.Models;

namespace Rask.Api.Operations;

public class EmployeeQuery
{
    [UseFirstOrDefault]
    [UseProjection]
    public IQueryable<Employee> GetEmployeeById(Guid id, RaskDbContext context)
        => context.Employees.Where(e => e.Id == id);

    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Employee> GetEmployees(RaskDbContext context)
        => context.Employees;
}
