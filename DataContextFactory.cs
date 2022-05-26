namespace WpfApp
{
    class DataContextFactory : IDataContextFactory
    {
        public DbContext CreateDbContext()
        {
            return new DataContext();
        }
    }
}
