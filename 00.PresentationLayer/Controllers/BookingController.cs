﻿using EsercizioBooking._01.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsercizioBooking._00.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class BookingController : ControllerBase
    {
        private readonly IBookingWorkerService _bookingWorkerService;

        public BookingController(IBookingWorkerService bookingWorkerService)
        {
            _bookingWorkerService = bookingWorkerService;
        }

    }
}
