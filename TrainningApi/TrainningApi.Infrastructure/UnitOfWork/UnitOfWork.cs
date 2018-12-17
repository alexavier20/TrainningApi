using System;
using TrainningApi.Domain.Interfaces.UnitOfWork;
using TrainningApi.Infrastructure.Context;

namespace TrainningApi.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrainningApiContext _context;
        private bool _disposed;

        public UnitOfWork(TrainningApiContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            //_context.SaveChanges();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {

                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }      
    }
}
