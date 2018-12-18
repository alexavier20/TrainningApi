using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrainningApi.Domain.DTO;
using TrainningApi.Domain.Entities;
using TrainningApi.Domain.Interfaces.Repository;
using TrainningApi.Infrastructure.Context;

namespace TrainningApi.Infrastructure.Repository
{
    public class RepositoryExampleItem : RepositoryBase<ExampleItem>, IRepositoryExampleItem, IDisposable
    {
        protected TrainningApiContext _Db;

        public RepositoryExampleItem(TrainningApiContext context) : base(context)
        {
            _Db = context;
        }

        public IQueryable<DTOExampleItem> GetListExampleItens(string name)
        {
            using (var transaction = Db.Database.BeginTransaction())
            {

            }
        }
    }
}
