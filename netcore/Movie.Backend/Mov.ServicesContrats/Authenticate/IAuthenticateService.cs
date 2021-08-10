using Mov.DataModels.ServiceResponse;
using Mov.DataModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov.ServicesContrats.Authenticate
{
   public  interface IAuthenticateService
    {
        Task<ServiceResponse> Register(string user); // sadece username ve password olacak.

        Task<ServiceResponse> Authenticate(User user);
    }
}
