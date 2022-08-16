using Application2.Features.someFeature.Commands.CreateSomeFeature;
using Application2.Features.someFeature.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeFeatureEntitiesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSomeFeatureEntityCommand createSomeFeatureEntityCommand)
        {
            CreatedSomeFeatureEntityDto result = await Mediator.Send(createSomeFeatureEntityCommand);
            return Created("", result);
        }

       
    }
}
