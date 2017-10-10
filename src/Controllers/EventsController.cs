using System;
using Microsoft.AspNetCore.Mvc;
using TechCalendar.MeetupAPI;

namespace WebApplicationBasic.Controllers
{
    public class EventsController : Controller
    {
        private readonly IMeetupEvents _meetupEvents;

        public EventsController(IMeetupEvents meetupEvents)
        {
            _meetupEvents = meetupEvents;
        }
        // GET
        [HttpGet("/api/events")]
        public IActionResult Index()
        {
            try
            {
                var events = _meetupEvents.GetEvents();
                return Ok(events);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}