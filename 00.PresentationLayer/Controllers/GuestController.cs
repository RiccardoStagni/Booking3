using EsercizioBooking._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioBooking._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestWorkerService _guestWorkerService;

        public GuestController(IGuestWorkerService guestWorkerService)
        {
            _guestWorkerService = guestWorkerService;
        }

    }
}
