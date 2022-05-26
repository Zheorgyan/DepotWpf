namespace WpfApp.Core
{
    public interface IDataContextFactory
    {
        DbContext CreateDbContext();
    }
}
