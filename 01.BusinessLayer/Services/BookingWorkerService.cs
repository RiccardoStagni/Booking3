using EsercizioBooking._01.BusinessLayer.Interfaces;
using EsercizioBooking._02.DataAccessLayer.Interfaces;

namespace EsercizioBooking._01.BusinessLayer.Services
{
    public class BookingWorkerService : IBookingWorkerService
    {
        private readonly IBookingDAS _bookingDAS;

        public BookingWorkerService(IBookingDAS bookingDAS)
        {
            _bookingDAS = bookingDAS;
        }
    }
}
