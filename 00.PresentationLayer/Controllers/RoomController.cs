using EsercizioBooking._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioBooking._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomWorkerService _roomWorkerService;

        public RoomController(IRoomWorkerService roomWorkerService)
        {
            _roomWorkerService = roomWorkerService;
        }

    }
}
