using Eventer.Contexts.EventContext.Entities;
using Eventer.Contexts.EventContext.Interfaces;

namespace Eventer.Contexts.EventContext.UseCases
{
    public class EventGetByIdCase
    {
        private readonly IEventRepository _eventRepository;

        public EventGetByIdCase(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Event Execute(int id)
        {
            return _eventRepository.FindById(id);
        }
    }
}
