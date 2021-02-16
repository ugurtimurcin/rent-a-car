using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Core.Business;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IGenericService<Car> _genericService;
        private readonly IMapper _mapper;
        public CarsController(IGenericService<Car> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _genericService.GetAllAsync();
            if (result.Success)
            {
                return Ok(_mapper.Map<List<CarDto>>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _genericService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(_mapper.Map<CarDto>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CarAddDto addDto)
        {
            var result = await _genericService.AddAsync(_mapper.Map<Car>(addDto));
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(CarUpdateDto updateDto)
        {
            var result = await _genericService.UpdateAsync(_mapper.Map<Car>(updateDto));
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _genericService.DeleteAsync(new Car { Id = id });
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
