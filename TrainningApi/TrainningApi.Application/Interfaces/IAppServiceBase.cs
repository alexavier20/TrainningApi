using System;
using System.Collections.Generic;
using System.Text;


namespace TrainningApi.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(int id);
        void Delete(TEntity obj);       
    }
}
