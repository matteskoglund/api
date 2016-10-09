using System;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using TodoApi;

namespace Tests
{


    public class TestToDo
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public TestToDo()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
            .UseStartup<Startup>());
            _client = _server.CreateClient();

        }   

        [Fact]
        public async Task GetAll()
        {
            // Act
            var response = await _client.GetAsync("/api/ToDo");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.StartsWith("[{\"key\":\"Nyckel\",\"name\":\"Item1\",\"isComplete",
            responseString);
        }
    
        [Fact]
        public async Task GetItem()
        {
            // Act
            var response = await _client.GetAsync("/api/ToDo/Nyckel");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.StartsWith("{\"key\":\"Nyckel\",\"name\":\"Item1\",\"isComplete",
            responseString);
        }

    }
}
