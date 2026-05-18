using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventer.Contexts.EventContext.DTOs.Requests;
using Eventer.Contexts.EventContext.UseCases;
using Eventer.Database.Schemas;
using Microsoft.AspNetCore.Mvc;

namespace Eventer.Contexts.EventContext.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly EventUpdateCase _updateCase;
        private readonly EventCreateCase _createCase;

        public EventController(EventUpdateCase updateCase, EventCreateCase createCase)
        {
            _updateCase = updateCase;
            _createCase = createCase;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateEventRequest request)
        {
            try { _createCase.Execute(request); }
            catch (Exception e) { return BadRequest(e.Message); }

            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateEventRequest request)
        {
            try { _updateCase.Execute(request); }
            catch (Exception e) { return BadRequest(e.Message); }

            return Ok();
        }

        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}