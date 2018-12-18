using System.Collections.Generic;
using System.Linq;
using TrainningApi.Domain.Interfaces.Repository;
using TrainningApi.Domain.Interfaces.Services;

namespace TrainningApi.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositorioBase;

        public ServiceBase(IRepositoryBase<TEntity> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public TEntity Add(TEntity obj)
        {
            return _repositorioBase.Add(obj);
        }

        public void AddRange(List<TEntity> obj)
        {
            _repositorioBase.AddRange(obj);
        }

        public List<TEntity> ComboBox()
        {
            return _repositorioBase.ComboBox();
        }

        public int Commit()
        {
            return _repositorioBase.SaveChanges();
        }

        public void Delete(int id)
        {
            _repositorioBase.Delete(id);
        }

        public void Delete(TEntity entity)
        {
            _repositorioBase.Delete(entity);
        }

        public void DeleteRange(List<TEntity> entity)
        {
            _repositorioBase.DeleteRange(entity);
        }

        public void Dispose()
        {
            _repositorioBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorioBase.GetAll();
        }

        public IQueryable<TEntity> GetAllAsNoTracking()
        {
            return _repositorioBase.GetAllAsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return _repositorioBase.GetById(id);
        }

        public void Update(TEntity obj)
        {
            _repositorioBase.Update(obj);
        }

        public void UpdateRange(List<TEntity> obj)
        {
            _repositorioBase.UpdateRange(obj);
        }
    }
}
