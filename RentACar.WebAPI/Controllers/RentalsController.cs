using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
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
    public class RentalsController : ControllerBase
    {
        private readonly IRentalService _rentalService;
        private readonly IMapper _mapper;
        public RentalsController(IRentalService rentalService, IMapper mapper)
        {
            _rentalService = rentalService;
            _mapper = mapper;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _rentalService.GetAllAsync();
            
            if (result.Success)
            {
                return Ok(_mapper.Map<List<RentalDto>>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _rentalService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(_mapper.Map<RentalDto>(result.Data));
            }
            return BadRequest(result);
        }

        [HttpGet("getrentaldetailbyid")]
        public async Task<IActionResult> GetAllDetail(int id)
        {
            var result = await _rentalService.GetRentalDetailByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getallrentaldetail")]
        public async Task<IActionResult> GetAllDetail()
        {
            var result = await _rentalService.GetRentalsDetailAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(RentalAddDto addDto)
        {
            var result = await _rentalService.AddAsync(_mapper.Map<Rental>(addDto));
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(RentalUpdateDto updateDto)
        {
            var result = await _rentalService.UpdateAsync(_mapper.Map<Rental>(updateDto));
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _rentalService.DeleteAsync(new Rental { Id = id });
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
