using System.Threading.Tasks;
using API.Repository;
using Business.Abstract;
using Business.Models.BaseDto;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BrandsController : ControllerRepository<IBrandService,BrandDto>
    {
        private readonly IBrandService _service;

        public BrandsController(IBrandService service):base(service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery]Filter filter)
        {
            var data =await _service.GetAllAsync(filter);
            
            return Ok(data);
        }
        
        
        
        
    }
}