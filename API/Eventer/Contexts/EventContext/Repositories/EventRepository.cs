using Eventer.Contexts.EventContext.DTOs.Requests;
using Eventer.Contexts.EventContext.Entities;
using Eventer.Contexts.EventContext.Interfaces;

namespace Eventer.Contexts.EventContext.Repositories
{
    public class EventRepository : IEventRepository
    {
        // NOTE: placeholder while there is no DB yet
        private static List<Event> _events = new List<Event>();

        public bool IsInDatabase(int id)
        {
            return (_events.Find(e => e.Id == id) != null);
        }

        public Event FindById(int id)
        {
            if (!IsInDatabase(id)) throw new Exception("could not find event!");

            return _events.Find(e => e.Id == id);
        }

        public void Update(UpdateEventRequest updateEvent)
        {
            for (int i = 0; i < _events.Count; i++)
            {
                if (_events[i].Id == updateEvent.Id)
                {
                    _events[i] = new Event 
                        { 
                            Name = updateEvent.Name, 
                            Description = updateEvent.Description, 
                            Date = updateEvent.Date, 
                            Capacity = updateEvent.Capacity, 
                            Location = updateEvent.Location, 
                            Price = updateEvent.Price
                        };
                    break;
                }
            }
        }
    }
}
