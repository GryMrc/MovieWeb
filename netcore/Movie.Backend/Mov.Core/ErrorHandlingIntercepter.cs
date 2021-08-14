using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mov.Core
{
    public class ErrorHandlingInterceptor : Grpc.Core.Interceptors.Interceptor
    {
        private const string SEE_INNER_MESSAGE = "An error occurred while updating the entries. See the inner exception for details.";

        public ErrorHandlingInterceptor()
        {
        }

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            try
            {
                return await continuation(request, context);
            }
            catch (RpcException rex)
            {
                throw;
            }
            
        }

    }
}
