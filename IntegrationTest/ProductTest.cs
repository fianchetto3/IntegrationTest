using System.Net.Http;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace IntegrationTest

{
    public class ProductTest(ITestOutputHelper output)
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new System.Uri("https://fakestoreapi.com/")
        };

        private readonly ITestOutputHelper _output = output;

        [Fact]
        public async Task GetProducts()
        {
            var result = await _httpClient.GetAsync("products");
            _output.WriteLine($"Statuskod: {(int)result.StatusCode} ({result.StatusCode})");
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

    }

}
