using Cloudmersive;
using Cloudmersive.APIClient.NET.Core;
//using Cloudmersive.APIClient.NET.Core.CloudmersiveClient;
using Microsoft.Rest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Cloudmersive.APIClient.NET.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBasic()
        {
            CloudmersiveClient client = new CloudmersiveClient(new ApiKeyCredentials("c392100b-db2f-4a66-b8ac-f9854435863f"));
            using (var result = client.ConvertWeb.UrlToPdf(new Models.Input() { Url = "http://github.com" }))
            {
                BinaryReader reader = new BinaryReader(result);
                File.WriteAllBytes("C:\\temp\\output.pdf", reader.ReadBytes(10000000));
            }
        }

        
    }
}
