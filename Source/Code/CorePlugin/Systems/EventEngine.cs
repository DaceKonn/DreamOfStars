using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsEngine.Singletons
{
    public delegate void EventHandlerDelegate<in TEvent>(TEvent @event)
        where TEvent : IEvent;

    public sealed class EventsDispatcher : IDisposable
    {
        private static readonly Lazy<EventsDispatcher> lazy =
            new Lazy<EventsDispatcher>(() => new EventsDispatcher());

        private Dictionary<Type, Delegate> _eventHandlers;

        public static EventsDispatcher Instance { get { return lazy.Value; } }

        private EventsDispatcher()
        {
            _eventHandlers = new Dictionary<Type, Delegate>();
        }

        private bool _disposed;

        //~EventsDispatcher()
        //{
        //    Dispose(false);
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // free other managed objects that implement IDisposable only
            }

            // release any unmanaged objects
            // set the object references to null
            RemoveAllListeners();
            _eventHandlers = null;

            _disposed = true;
        }

        public void AddListener<TEvent>(EventHandlerDelegate<TEvent> handler)
     where TEvent : IEvent
        {
            Delegate @delegate;
            if (_eventHandlers.TryGetValue(typeof(TEvent), out @delegate))
            {
                _eventHandlers[typeof(TEvent)] = Delegate.Combine(@delegate, handler);
            }
            else
            {
                _eventHandlers[typeof(TEvent)] = handler;
            }
        }

        public void RemoveListener<TEvent>(EventHandlerDelegate<TEvent> handler)
     where TEvent : IEvent
        {
            Delegate @delegate;
            if (_eventHandlers.TryGetValue(typeof(TEvent), out @delegate))
            {
                Delegate currentDel = Delegate.Remove(@delegate, handler);

                if (currentDel == null)
                {
                    _eventHandlers.Remove(typeof(TEvent));
                }
                else
                {
                    _eventHandlers[typeof(TEvent)] = currentDel;
                }
            }
        }

        public void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent
        {
            if (@event == null)
            {
                throw new ArgumentNullException("event");
            }

            Delegate @delegate;
            if (_eventHandlers.TryGetValue(typeof(TEvent), out @delegate))
            {
                (@delegate as EventHandlerDelegate<TEvent>)?.Invoke(@event);
            }
        }

        /// <summary>
        /// This dispatch will use Dispatch method but in a seperate Task without waiting for result,
        /// use with caution, possibly only with sending events from UI
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="event"></param>
        public static void NonLockingDispatch<TEvent>(TEvent @event) where TEvent : IEvent
        {
            new Task(() => Instance.Dispatch<TEvent>(@event)).Start();
        }

        private void RemoveAllListeners()
        {
            var handlerTypes = new Type[_eventHandlers.Keys.Count];
            _eventHandlers.Keys.CopyTo(handlerTypes, 0);

            foreach (Type handlerType in handlerTypes)
            {
                Delegate[] delegates = _eventHandlers[handlerType].GetInvocationList();
                foreach (Delegate @delegate1 in delegates)
                {
                    var handlerToRemove = Delegate.Remove(_eventHandlers[handlerType], @delegate1);
                    if (handlerToRemove == null)
                    {
                        _eventHandlers.Remove(handlerType);
                    }
                    else
                    {
                        _eventHandlers[handlerType] = handlerToRemove;
                    }
                }
            }
        }
    }
}
