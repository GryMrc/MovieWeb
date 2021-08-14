using Mov.DataModels.User;
using Mov.Mutual;
using Mov.ServicesContrats.Authenticate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mov.Services.Authenticate
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly ApplicationDbContext context;

        public AuthenticateService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void myfunc(string x)
        {
            return;
        }

        public async Task<string> Register(User my)
        {
            //ajsdjsadadja
            //jaksdkjashdkjsahd
            var a = "asdas";
            return a;
        }
    }
}
