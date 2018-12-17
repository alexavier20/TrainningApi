namespace TrainningApi.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Dispose();
    }
}
