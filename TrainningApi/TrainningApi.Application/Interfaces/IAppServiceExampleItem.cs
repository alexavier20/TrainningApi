using System;
using System.Collections.Generic;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;
using TrainningApi.Domain.Interfaces.UnitOfWork;

namespace TrainningApi.Application.Interfaces
{
    public interface IAppServiceExampleItem : IAppServiceBase<ExampleItem>, IUnitOfWork
    {
        Boolean AddExampleItem(DTOExampleItem param);

        void UpdateExampleItem(int param);

        List<DTOExampleItem> GetListExampleItens(string name);
    }
}
