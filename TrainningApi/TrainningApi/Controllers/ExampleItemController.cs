using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainningApi.Adapter;
using TrainningApi.Application.Interfaces;
using TrainningApi.Domain.DTO;
using TrainningApi.Infrastructure.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainningApi.Controllers
{
    [Route("api/[controller]")]

    public class ExampleItemController : ControllerBase
    {
        private IAppServiceExampleItem _exampleItemAppService;
        private readonly AdapterExampleItem _adapterExampleItem;

        public ExampleItemController(IAppServiceExampleItem exampleItemAppService, AdapterExampleItem adapterExampleItem)
        {
            _exampleItemAppService = exampleItemAppService;
            _adapterExampleItem = adapterExampleItem;
        }

        [HttpPost]
        [Route("[action]")]
        [Produces("application/json")]
        public IActionResult CreateExampleItem([FromBody] DTOExampleItem param)
        {
            try
            {
                var result = _exampleItemAppService.Add(param);

                if (result)
                {
                    return Ok(new ResponseMessageAjax() { CssClassName = "alert-sucess", Message = "Reclamação Cadastrada com Sucesso.", Success = true, Title = "Sucesso" });
                }
                else
                {
                    return NotFound(new ResponseMessageAjax() { CssClassName = "alert-warning", Message = "Campos Obrigatórios não forma informados.", Success = false, Title = "Aviso" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseMessageAjax() { CssClassName = "alert-danger", Message = ex.Message, Success = false, Title = "Error" });

            }
        }
    }
}
