using Grpc.Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov.Core
{
    public class Class5
    {
        private const string HEADER_KEY = "ot-context";

        private readonly IHttpContextAccessor _httpContextAccessor;

        public Class5(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Metadata AddCallContext(Metadata metadata)
        {
            if (_httpContextAccessor.HttpContext?.Items?.ContainsKey(HEADER_KEY) == true)
            {
                metadata.Add(new Metadata.Entry(HEADER_KEY, _httpContextAccessor.HttpContext.Items[HEADER_KEY].ToString()));
            }
            return metadata;
        }
    }
}
