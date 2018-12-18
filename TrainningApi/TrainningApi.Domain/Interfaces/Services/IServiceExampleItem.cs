using System.Collections.Generic;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;

namespace TrainningApi.Domain.Interfaces.Services
{
    public interface IServiceExampleItem : IServiceBase<ExampleItem>
    {
        List<DTOExampleItem> GetListExampleItens(string name);
    }
}
