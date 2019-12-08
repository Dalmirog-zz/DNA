using System;
using System.Collections.Generic;
using DNA.Model;
using Microsoft.AspNetCore.Mvc;

namespace DNA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HowLongController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<HowLong> Get()
        {
            return new HowLong()
            {
                CurrentUtcTime = DateTime.UtcNow,
                NextMeetingTime = DateTime.Parse("2019/12/18 21:00:00")
            };
        }
    }
}