namespace Rask.Api.Db;

public static class DbConnectionString
{
    /// <summary>
    /// Create datbase connection string.
    /// </summary>
    /// <returns>Database file path.</returns>
    public static string Create(bool IsDevelopment)
    {
        if (IsDevelopment)
        {
            // build database file path
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            return System.IO.Path.Combine(path, "dev.db");
        }

        return string.Empty;
    }
}
