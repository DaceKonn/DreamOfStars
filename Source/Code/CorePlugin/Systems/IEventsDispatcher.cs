using DreamOfStars.Events;

namespace DreamOfStars.Systems
{
    public delegate void EventHandlerDelegate<in TEvent>(TEvent @event)
    where TEvent : IEvent;

    public interface IEventsDispatcher
    {
        void AddListener<TEvent>(EventHandlerDelegate<TEvent> handler) where TEvent : IEvent;
        void Dispatch<TEvent>(TEvent @event) where TEvent : IEvent;
        void Dispose();
        void RemoveListener<TEvent>(EventHandlerDelegate<TEvent> handler) where TEvent : IEvent;
        void NonLockingDispatch<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}