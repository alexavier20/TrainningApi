using System;
using System.Collections.Generic;
using System.Linq;
using TrainningApi.Domain.DTO;
using TrainningApi.ViewModels;

namespace TrainningApi.Adapter
{
    public class AdapterExampleItem
    {
        public List<ViewModelExampleItem> adapter(List<DTOExampleItem> listDTO)
        {
            var resultado = (from item in listDTO
                             select new ViewModelExampleItem()
                             {
                                 Id = item.Id,
                                 IsComplete = item.IsComplete,
                                 Name = item.Name 

                             }).ToList();

            return resultado;
        }
    }
}
