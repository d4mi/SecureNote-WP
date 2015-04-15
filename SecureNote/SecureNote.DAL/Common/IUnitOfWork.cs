namespace SecureNote.DAL
{
    public interface IUnitOfWork : System.IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, new();
        void SubmitChanges();
    }
}
