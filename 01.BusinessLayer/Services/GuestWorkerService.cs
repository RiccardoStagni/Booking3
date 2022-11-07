using EsercizioBooking._01.BusinessLayer.Interfaces;
using EsercizioBooking._02.DataAccessLayer.Interfaces;

namespace EsercizioBooking._01.BusinessLayer.Services
{
    public class GuestWorkerService : IGuestWorkerService
    {
        private readonly IGuestDAS _guestDAS;

        public GuestWorkerService(IGuestDAS guestDAS)
        {
            _guestDAS = guestDAS;
        }

    }
}
