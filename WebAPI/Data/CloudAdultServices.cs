using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Assignment.Model;

namespace WebApi.Data
{
    public class CloudAdultServices : IFileContext
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;

        public CloudAdultServices()
        {
            client = new HttpClient();
        }
        public async Task<Adult> AddAdultsAsync(Adult adult)
        {
            string AdultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(AdultAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync(uri + "/Adults", content);
            return adult;
        }

        // public async Task<IList<Family>> GetFamiliesAsync()
        // {

        // }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/Adults");
            string message = await stringAsync;
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }

        public async Task RevomeAdultsAsync(int Id)
        {
            await client.DeleteAsync($"{uri}/Adults/{Id}");
        }
    }
}