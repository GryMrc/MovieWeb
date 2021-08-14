using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mov.Core
{
        public class CallContextInterceptor : Grpc.Core.Interceptors.Interceptor
        {

            public CallContextInterceptor()
            {
            }

            public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
            {
               
                return await continuation(request, context);
            }
        }
    }
