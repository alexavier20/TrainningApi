using System;
using System.Collections.Generic;
using System.Text;
using TrainningApi.Domain.Entities;
using TrainningApi.Domain.Interfaces.UnitOfWork;

namespace TrainningApi.Application.Interfaces
{
    public interface IAppServiceExampleItem : IAppServiceBase<ExampleItem>, IUnitOfWork
    {
    }
}
