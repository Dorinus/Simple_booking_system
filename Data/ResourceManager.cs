using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Simple_booking_system.Models;

namespace Simple_booking_system.Data.Migrations
{
    public class ResourceManager : IResourcesManager
    {
        private HttpClient Client;
        private String Uri;

        public ResourceManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5003";
        }


        //Gets the list with all resources
        public async Task<IList<Resource>> GetResources()
        {
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/Resourse/");
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Resource> resources = JsonSerializer.Deserialize<IList<Resource>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return resources;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}