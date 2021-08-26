using System.Threading.Tasks;
using API.Repository;
using Business.Abstract;
using Business.Models.BaseDto;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FavoriteProductsController : ControllerRepository<IFavoriteProductService,FavoriteProductDto>
    {
        private readonly IFavoriteProductService _service;

        public FavoriteProductsController(IFavoriteProductService service):base(service)
        {
            _service = service;
        }

        [HttpGet("{accountId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAllByAccountAsync([FromQuery]Filter filter, int accountId)
        {
            var data =await _service.GetAllByAccountAsync(filter,accountId);
            return Ok(data);
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAllAsync([FromQuery]Filter filter )
        {
            var data =await _service.GetAllAsync(filter);
            return Ok(data);
        }

    }
}