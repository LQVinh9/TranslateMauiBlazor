using Newtonsoft.Json;
using System.Text;
using TranslateMauiBlazor.Common;
using TranslateMauiBlazor.Interfaces;
using TranslateMauiBlazor.Models;

namespace TranslateMauiBlazor.Services
{
    internal class TranslateService : ITranslateService
    {
        public async Task<List<TranslateModel>> TranslateLanguage(string text, string[] languages)
        {
            string listLanguage = string.Join("&to=", languages);
            string route = "/translate?api-version=3.0&to="+listLanguage;
            object[] body = new object[] { new { Text = text } };
            var requestBody = JsonConvert.SerializeObject(body);

            using var client = new HttpClient();

            using var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(Config.ENDPOINT + route);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("Ocp-Apim-Subscription-Key", Config.KEY);
            request.Headers.Add("Ocp-Apim-Subscription-Region", Config.LOCATION);

            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
            string result = await response.Content.ReadAsStringAsync();
            List<TranslateModel> translations = JsonConvert.DeserializeObject<List<TranslateModel>>(result);

            return translations;
        }
    }
}
