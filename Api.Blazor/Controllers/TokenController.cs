﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Blazor.Interfaces.auth;
using Api.Blazor.Models.DTO;

using Microsoft.AspNetCore.Authorization;

namespace Api.Blazor.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJwtAuthenticationService _authService;

        public TokenController(IJwtAuthenticationService auth)
        {

            _authService = auth;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthInfo user)
        {
            var token = _authService.Authenticate(user.Username, user.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);

        }

    }
}
