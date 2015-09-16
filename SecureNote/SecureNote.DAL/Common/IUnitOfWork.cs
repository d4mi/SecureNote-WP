namespace SecureNote.DAL
{
    public interface IUnitOfWork : System.IDisposable
    {
        void SetConnectionString(string connectionString);
        IRepository<T> GetRepository<T>() where T : class, new();
        void SubmitChanges();
    }
}
