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
    public class ColorsController : ControllerBase
    {
        private readonly IGenericService<Color> _genericService;
        private readonly IMapper _mapper;
        public ColorsController(IGenericService<Color> genericService, IMapper mapper)
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
                return Ok(_mapper.Map<List<ColorDto>>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _genericService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(_mapper.Map<ColorDto>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ColorAddDto addDto)
        {
            var result = await _genericService.AddAsync(_mapper.Map<Color>(addDto));
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ColorUpdateDto updateDto)
        {
            var result = await _genericService.UpdateAsync(_mapper.Map<Color>(updateDto));
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _genericService.DeleteAsync(new Color { Id = id });
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
