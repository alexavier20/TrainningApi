using System.Collections.Generic;
using System.Linq;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;

namespace TrainningApi.Domain.Interfaces.Repository
{
    public interface IRepositoryExampleItem : IRepositoryBase<ExampleItem>
    {
        IQueryable<DTOExampleItem> GetListExampleItens(string name);
    }
}
