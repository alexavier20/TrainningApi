using System.Collections.Generic;
using System.Linq;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;
using TrainningApi.Domain.Interfaces.Repository;
using TrainningApi.Domain.Interfaces.Services;

namespace TrainningApi.Domain.Service
{
    public class ServiceExampleItem : ServiceBase<ExampleItem>, IServiceExampleItem
    {
        private readonly IRepositoryExampleItem _IRepositoryExampleItem;

        public ServiceExampleItem(IRepositoryExampleItem repositoryExampleItem) : base(repositoryExampleItem)
        {
            _IRepositoryExampleItem = repositoryExampleItem;
        }

        public List<DTOExampleItem> GetListExampleItens(string name)
        {
            return _IRepositoryExampleItem.
        }

        public ExampleItem Add(ExampleItem obj)
        {
            return _IRepositoryExampleItem.Add(obj);
        }

        public void AddRange(List<ExampleItem> obj)
        {
            _IRepositoryExampleItem.AddRange(obj);
        }

        public void Delete(ExampleItem entity)
        {
            _IRepositoryExampleItem.Delete(entity);
        }

        public void DeleteRange(List<ExampleItem> entity)
        {
            _IRepositoryExampleItem.DeleteRange(entity);
        }       

        public void Update(ExampleItem obj)
        {
            _IRepositoryExampleItem.Update(obj);
        }

        public void UpdateRange(List<ExampleItem> obj)
        {
            _IRepositoryExampleItem.UpdateRange(obj);
        }

        List<ExampleItem> IServiceBase<ExampleItem>.ComboBox()
        {
            return _IRepositoryExampleItem.ComboBox();
        }

        IEnumerable<ExampleItem> IServiceBase<ExampleItem>.GetAll()
        {
            return _IRepositoryExampleItem.GetAll();
        }

        IQueryable<ExampleItem> IServiceBase<ExampleItem>.GetAllAsNoTracking()
        {
            return _IRepositoryExampleItem.GetAllAsNoTracking();
        }

        ExampleItem IServiceBase<ExampleItem>.GetById(int id)
        {
            return _IRepositoryExampleItem.GetById(id);
        }
    }
}
