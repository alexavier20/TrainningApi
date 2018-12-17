using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainningApi.Infrastructure.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainningApi.Controllers
{
    [Route("api/[controller]")]
    
    public class ExampleItemController : ControllerBase
    {
        private readonly TrainningApiContext _context;

        public ExampleItemController (TrainningApiContext context)
        {
           
        }
    }
}
