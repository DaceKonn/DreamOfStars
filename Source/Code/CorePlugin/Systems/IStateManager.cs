using DreamOfStars.Events;

namespace DreamOfStars.Systems
{
    public interface IStateManager
    {
        void SaveGameStateEventHandler(SaveGameStateEvent e);
        void LoadGameStateEventHandler(LoadGameStateEvent e);
        int[] GetSaveSlotsNumbers();
    }
}