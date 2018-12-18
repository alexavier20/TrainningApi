using System;
using System.Collections.Generic;
using System.Text;
using TrainningApi.Application.Interfaces;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;
using TrainningApi.Domain.Interfaces.Services;
using TrainningApi.Domain.Interfaces.UnitOfWork;

namespace TrainningApi.Application.AppServices
{
    public class AppServiceExampleItem : AppService, IAppServiceExampleItem, IUnitOfWork
    {
        private readonly IServiceExampleItem _ServiceExampleItem;
        private readonly IUnitOfWork _IUnitOfWork;
        private readonly IAppServiceExampleItem _AppServiceExampleItem;

        public AppServiceExampleItem (IServiceExampleItem serviceExampleItem, IUnitOfWork uow, IAppServiceExampleItem appServiceExampleItem) : base(uow)
        {
            _ServiceExampleItem = serviceExampleItem;
            _IUnitOfWork = uow;
            _AppServiceExampleItem = appServiceExampleItem;
        }

        public bool AddExampleItem(DTOExampleItem param)
        {
            //Realizar verificação dos campos para o resultado do retorno.

            ExampleItem obj = new ExampleItem();
            obj.Id = param.Id;
            obj.Name = param.Name;
            obj.IsComplete = param.IsComplete;

            this.BeginTransaction();

            _ServiceExampleItem.Add(obj);

            this.Commit();

            return true;           
        }

        public void UpdateExampleItem(DTOExampleItem param)
        {
            ExampleItem obj = _ServiceExampleItem.GetById(param.Id);
            obj.Id = param.Id;
            obj.Name = param.Name;
            obj.IsComplete = param.IsComplete;

            this.BeginTransaction();

            _ServiceExampleItem.Update(obj);

            this.Commit();
        }

        public List<DTOExampleItem> GetListExampleItens(string name)
        {
            throw new NotImplementedException();
        }

        public ExampleItem Add(ExampleItem obj)
        {
            return _ServiceExampleItem.Add(obj);
        }       

        public void Delete(int id)
        {
            _ServiceExampleItem.Delete(id);
        }

        public void Delete(ExampleItem obj)
        {
            _ServiceExampleItem.Delete(obj);
        }

        public IEnumerable<ExampleItem> GetAll()
        {
            return _ServiceExampleItem.GetAll();
        }

        public ExampleItem GetById(int id)
        {
            return _ServiceExampleItem.GetById(id);
        }      

        public void Update(ExampleItem obj)
        {
            _ServiceExampleItem.Update(obj);
        }       
    }
}
