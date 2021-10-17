using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Simple_booking_system.Models;

namespace Simple_booking_system.Data
{
    public class BookingManager : IBookingManager
    {
        private HttpClient Client { get; set; }
        private String Uri { get; set; }

        public BookingManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5003";
        }

        // Posting a new Booking
        public async Task<Booking> NewBooking(Booking booking)
        {
            String productAsJson = JsonSerializer.Serialize(booking);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/Booking", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                Booking returnedBooking = JsonSerializer.Deserialize<Booking>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return returnedBooking;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}