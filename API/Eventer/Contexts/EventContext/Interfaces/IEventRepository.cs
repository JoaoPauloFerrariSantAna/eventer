using Eventer.Contexts.EventContext.DTOs.Requests;
using Eventer.Contexts.EventContext.Entities;

namespace Eventer.Contexts.EventContext.Interfaces
{
    public interface IEventRepository
    {
        public Event FindById(int Id);
        public void Update(UpdateEventRequest updateEvent);
    }
}
