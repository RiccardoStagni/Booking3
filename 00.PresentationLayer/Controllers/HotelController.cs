using EsercizioBooking._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioBooking._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelWorkerService _hotelWorkerService;

        public HotelController(IHotelWorkerService hotelWorkerService)
        {
            _hotelWorkerService = hotelWorkerService;
        }

    }
}
