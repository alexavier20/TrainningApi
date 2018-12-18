using System.Collections.Generic;
using System.Linq;

namespace TrainningApi.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetAllAsNoTracking();
        List<TEntity> ComboBox();
        void AddRange(List<TEntity> obj);
        void UpdateRange(List<TEntity> obj);
        void DeleteRange(List<TEntity> entity);
        void Update(TEntity obj);
        void Dispose();
        int Commit();
        void Delete(int id);
        void Delete(TEntity entity);
    }
}
