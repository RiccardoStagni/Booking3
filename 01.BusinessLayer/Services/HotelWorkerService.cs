using EsercizioBooking._01.BusinessLayer.Interfaces;
using EsercizioBooking._02.DataAccessLayer.Interfaces;

namespace EsercizioBooking._01.BusinessLayer.Services
{
    public class HotelWorkerService : IHotelWorkerService
    {
        private readonly IHotelDAS _hotelDAS;

        public HotelWorkerService(IHotelDAS hotelDAS)
        {
            _hotelDAS = hotelDAS;
        }
    }
}
