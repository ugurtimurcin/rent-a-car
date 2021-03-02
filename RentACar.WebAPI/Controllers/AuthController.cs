using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Abstract;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto loginDto)
        {
            var userToLogin = _authService.Login(loginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            var result = await _authService.CreateAccessTokenAsync(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto registerDto)
        {
            var userExists = await _authService.UserExistsAsync(registerDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.RegisterAsync(registerDto).Result;
            var result = await _authService.CreateAccessTokenAsync(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
