using TrainningApi.Domain.Interfaces.UnitOfWork;

namespace TrainningApi.Application.AppServices
{
    public class AppService
    {
        private readonly IUnitOfWork _uow;
        //protected ValidationResult ValidationResult { get; private set; }

        public AppService(IUnitOfWork uow)
        {
            _uow = uow;

            //ValidationResult = new ValidationResult();
        }

        public virtual void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public virtual void Commit()
        {
            _uow.Commit();
        }

        public virtual void Dispose()
        {

        }
    }
}
