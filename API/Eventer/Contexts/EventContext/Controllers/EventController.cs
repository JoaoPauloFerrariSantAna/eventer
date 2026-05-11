using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventer.Contexts.EventContext.DTOs.Requests;
using Eventer.Database.Schemas;
using Microsoft.AspNetCore.Mvc;

namespace Eventer.Contexts.EventContext.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        [HttpPost]
        public void Post(CreateEventRequest request)
        {
        }
        [HttpPut]
        public void Update(UpdateEventRequest request)
        {
        }
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}