using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TrainningApi.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        void AddRange(List<TEntity> obj);
        void UpdateRange(List<TEntity> obj);
        void DeleteRange(List<TEntity> entity);
        void Delete(int id);
        void Delete(TEntity entity);
        void Dispose();
        IEnumerable<TEntity> GetAll();
        List<TEntity> ComboBox();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, Boolean>> predicate, Boolean @readonly = true, IList<String> eagerLoads = null, int take = 0);
        void UpdateBatch(Expression<Func<TEntity, bool>> filterExpression, Expression<Func<TEntity, TEntity>> updateExpression);
        IQueryable<TEntity> GetAllAsNoTracking();
        TEntity GetById(int id);
        int SaveChanges();
        void RejectChanges();
        void Update(TEntity obj);
    }
}
