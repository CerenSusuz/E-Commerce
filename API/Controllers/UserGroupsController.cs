﻿using System.Threading.Tasks;
using API.Repository;
using Business.Abstract;
using Business.Models.BaseDto;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserGroupsController : ControllerRepository<IUserGroupService,UserGroupDto>
    {
        private readonly IUserGroupService _service;

        public UserGroupsController(IUserGroupService service):base(service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAll([FromQuery]Filter filter)
        {
            var data =await _service.GetAllAsync(filter);
            
            return Ok(data);
        }
        
        
        
        
    }
}