using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cloudmersive
{
    public class ApiKeyCredentials : ServiceClientCredentials
    {
        string Key;

        public ApiKeyCredentials(string key)
        {
            Key = key;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Apikey", Key);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
