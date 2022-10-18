using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class ThisWeekEvents : IEnumerable<Event>
    {
        private readonly FacebookObjectCollection<Event> r_EventsCollection;

        public ThisWeekEvents(FacebookObjectCollection<Event> i_ThisWeekEvents)
        {
            r_EventsCollection = i_ThisWeekEvents;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Event> GetEnumerator()
        {
            foreach (Event currEvent in r_EventsCollection)
            {
                if (currEvent.StartTime > DateTime.Now.AddDays(7) || currEvent.StartTime < DateTime.Now)
                {
                    yield return currEvent;
                }
            }
        }
    }
}
