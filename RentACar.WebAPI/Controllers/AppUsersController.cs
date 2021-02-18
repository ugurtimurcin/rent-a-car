using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
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
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;
        public AppUsersController(IAppUserService appUserService, IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _appUserService.GetAllAsync();
            if (result.Success)
            {
                return Ok(_mapper.Map<List<AppUserDto>>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _appUserService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(_mapper.Map<AppUserDto>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AppUserAddDto addDto)
        {
            var result = await _appUserService.AddAsync(_mapper.Map<AppUser>(addDto));
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(AppUserUpdateDto updateDto)
        {
            var result = await _appUserService.UpdateAsync(_mapper.Map<AppUser>(updateDto));
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _appUserService.DeleteAsync(new AppUser { Id = id });
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }

    }
}
