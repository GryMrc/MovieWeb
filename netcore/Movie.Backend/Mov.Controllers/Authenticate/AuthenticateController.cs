using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mov.DataModels.ServiceResponse;
using Mov.DataModels.User;
using Mov.ServicesContrats.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mov.Controllers.Authenticate
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        public async  Task<string> Register(User user)
        {
             return await _authenticateService.Register(user);
        }
    }
}
