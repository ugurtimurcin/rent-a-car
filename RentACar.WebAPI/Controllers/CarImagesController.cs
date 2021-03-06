﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;
        private readonly IMapper _mapper;
        public CarImagesController(ICarImageService carImageService, IMapper mapper)
        {
            _carImageService = carImageService;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromForm] CarImageDto imageDto, List<IFormFile> files)
        {
            var result = await _carImageService.AddAsync(_mapper.Map<CarImage>(imageDto), files);
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromForm]CarImageDto imageDto, IFormFile file)
        {
            var result = await _carImageService.UpdateAsync(_mapper.Map<CarImage>(imageDto), file);
            if (result.Success)
            {
                return Created("", result);
            }
            return BadRequest();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var carImage = await _carImageService.GetByIdAsync(id);
            var result = await _carImageService.DeleteAsync(carImage.Data);
            if (result.Success)
            {
                return NoContent();
            }

            return BadRequest();
        }


    }
}
