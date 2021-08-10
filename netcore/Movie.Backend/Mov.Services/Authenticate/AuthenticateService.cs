using Mov.DataModels.ServiceResponse;
using Mov.DataModels.User;
using Mov.ServicesContrats.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mov.Services.Authenticate
{
    public class AuthenticateService : IAuthenticateService
    {
        public async Task<ServiceResponse> Authenticate(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse> Register(string user)
        {
            return ServiceResponse.SuccessfulResponse();
        }
    }
}
