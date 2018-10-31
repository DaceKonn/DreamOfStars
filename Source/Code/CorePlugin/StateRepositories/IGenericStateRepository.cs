using DreamOfStars.States;

namespace DreamOfStars.StateRepositories
{
    public interface IGenericStateRepository<T> where T : AbstractState
    {
        T GetState(int id);
        //void LoadState(string saveLocation);
        //void SaveState(string saveLocation);
        void UpdateState(T state);
        T NewState();
    }
}