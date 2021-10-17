using System.Threading.Tasks;
using Simple_booking_system.Models;

namespace Simple_booking_system.Data
{
    public interface IBookingManager
    {
        Task<Booking> NewBooking(Booking booking);
    }
}