namespace SecureNote.DAL
{
    public interface IUnitOfWork : System.IDisposable
    {
        Repository<T> GetRepository<T>() where T : class, new();
        void SubmitChanges();
    }
}
