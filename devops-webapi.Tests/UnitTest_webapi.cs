using System;
using Xunit;
using Moq;
using System.Threading.Tasks;
using devops_webapi.Controllers;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Net;

namespace devops_webapi.Tests
{
    public class UnitTest_webapi
    {
        private readonly HttpClient _client;

        public UnitTest_webapi()
        {
            var myserver = new TestServer(new WebHostBuilder()
            .UseEnvironment("Development")
            .UseStartup<Startup>());
            _client = myserver.CreateClient();
        }
        

        [Theory]
        [InlineData("GET", 1)]
        public async Task TestgetnumbersAsync(string method, int? id = null)
        {
            var myrequest = new HttpRequestMessage(new HttpMethod(method), $"/numbers/{id}");

            var myresponse = await _client.SendAsync(myrequest);

            myresponse.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, myresponse.StatusCode);

        }

        [Theory]
        [InlineData("GET", 2)]
        public async Task TestgetvaluesAsync(string method, int? id = null)
        {
            var myrequest = new HttpRequestMessage(new HttpMethod(method), $"/numbers/{id}");

            var myresponse = await _client.SendAsync(myrequest);

            string returnValue = await myresponse.Content.ReadAsStringAsync();
            Assert.Equal("Two", returnValue);

        }
    }
}
