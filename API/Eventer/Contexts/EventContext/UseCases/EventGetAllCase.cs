using Eventer.Contexts.EventContext.Entities;
using Eventer.Contexts.EventContext.Interfaces;

namespace Eventer.Contexts.EventContext.UseCases
{
    public class EventGetAllCase
    {
        private readonly IEventRepository _eventRepository;

        public EventGetAllCase(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public List<Event> Execute()
        {
            return _eventRepository.GetAll();
        }
    }
}
