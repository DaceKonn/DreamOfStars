using DreamOfStars.Events;

namespace DreamOfStars.Systems
{
    public interface IMainGameManager
    {
        void StartNewGameEventHandler(StartNewGameEvent @event);
        void LoadSelectedGameSlotEventHandler(LoadSelectedGameSlotEvent @event);
    }
}