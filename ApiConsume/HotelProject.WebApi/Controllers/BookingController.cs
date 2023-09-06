using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddService(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateService(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut("aaaaa")]
        public IActionResult aaaaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bbbbb")]
        public IActionResult bbbbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
