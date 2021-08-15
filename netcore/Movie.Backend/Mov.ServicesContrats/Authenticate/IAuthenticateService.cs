using Mov.Core;
using Mov.DataModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Mov.ServicesContrats.Authenticate
{
   [ServiceContract]
   public  interface IAuthenticateService:IBase
    {
        void myfunc(string x);

        
        Task<string> Register(User my); // sadece username ve password olacak.

    }
}
