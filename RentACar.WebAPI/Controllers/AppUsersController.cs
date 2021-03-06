﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IUserService _appUserService;
        private readonly IMapper _mapper;
        public AppUsersController(IUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _appUserService.GetAllAsync();
            if (result.Success)
            {
                return Ok(_mapper.Map<List<UserDto>>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _appUserService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(_mapper.Map<UserDto>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(UserAddDto addDto)
        {
            var result = await _appUserService.AddAsync(_mapper.Map<User>(addDto));
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UserUpdateDto updateDto)
        {
            var result = await _appUserService.UpdateAsync(_mapper.Map<User>(updateDto));
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _appUserService.DeleteAsync(new User { Id = id });
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
