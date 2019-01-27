using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncInLegacyUI
{
    public class GoogleClient
    {
        public async Task<string> GetResponseFromGoogle(TimeSpan wait = default(TimeSpan))
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://www.google.com")
            };

            await Task.Delay(wait);

            var response = await httpClient.GetAsync("");
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }


        public async Task<HttpResponseMessage> GetHttpResponseMessageFromGoogle(TimeSpan wait = default(TimeSpan))
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://www.google.com")
            };

            await Task.Delay(wait);

            var response = await httpClient.GetAsync("");
          

            return response;
        }
    }
}