using Application.Features.CarModels.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListModelListItemDto> response = await Mediator.Send(getListModelQuery);
            return Ok(response);
        }
    }
}
