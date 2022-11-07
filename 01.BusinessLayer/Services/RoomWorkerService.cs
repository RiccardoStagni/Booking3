using EsercizioBooking._01.BusinessLayer.Interfaces;
using EsercizioBooking._02.DataAccessLayer.Interfaces;

namespace EsercizioBooking._01.BusinessLayer.Services
{
    public class RoomWorkerService : IRoomWorkerService
    {
        private readonly IRoomDAS _roomDAS;

        public RoomWorkerService(IRoomDAS roomDAS)
        {
            _roomDAS = roomDAS;
        }

    }
}
