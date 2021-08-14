using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov.Core
{
    public class Class4 : Interceptor
    {
        private const string EMPTY_DETAIL = "No message returned from method.";

        public Class4()
        {
        }

        private static async Task<TResponse> HandleResponse<TResponse>(Task<TResponse> t)
        {
            try
            {
                return await t;
            }
            catch (RpcException rex) when (rex.Status.Detail == EMPTY_DETAIL)
            {
                return default;
            }
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var call = continuation(request, context);
            return new AsyncUnaryCall<TResponse>(HandleResponse(call.ResponseAsync), call.ResponseHeadersAsync, call.GetStatus, call.GetTrailers, call.Dispose);
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            try
            {
                return base.BlockingUnaryCall(request, context, continuation);
            }
            catch (RpcException rex) when (rex.Status.Detail == EMPTY_DETAIL)
            {
                return default;
            }
        }
    }
}
