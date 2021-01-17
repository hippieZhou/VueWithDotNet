﻿using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using VueWithDotNet.Application.Interfaces;

namespace VueWithDotNet.Services
{
    public class AuthenticatedUserService : IAuthenticatedUserService
    {
        public AuthenticatedUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue("uid");
        }

        public string UserId { get; }
    }
}
