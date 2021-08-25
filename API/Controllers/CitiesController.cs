using System.Threading.Tasks;
using API.Repository;
using Business.Abstract;
using Business.Models.BaseDto;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CitiesController : ControllerRepository<ICityService,CityDto>
    {
        private readonly ICityService _service;

        public CitiesController(ICityService service):base(service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAll([FromQuery]Filter filter, int countryId)
        {
            var data =await _service.GetAllAsync(filter,countryId);
            return Ok(data);
        }

    }
}