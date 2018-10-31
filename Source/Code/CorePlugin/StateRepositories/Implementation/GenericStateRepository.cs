using DreamOfStars.Events.RepositoryEvents;
using DreamOfStars.States;
using DreamOfStars.Systems;
using Newtonsoft.Json;
using Singularity;
using System.Collections.Generic;
using System.Linq;

namespace DreamOfStars.StateRepositories.Implementation
{
    public class GenericStateRepository<T> : IGenericStateRepository<T> where T : AbstractState, new()
    {
        
        private Dictionary<int, T> _repository { get; set; }
        private IEventsDispatcher _eventsDispatcher { get; set; }

        [Inject]
        public void Inject(IEventsDispatcher eventsDispatcher)
        {
            _eventsDispatcher = eventsDispatcher;
        }

        public GenericStateRepository(IEventsDispatcher eventsDispatcher)
        {
            Inject(eventsDispatcher);
            _repository = new Dictionary<int, T>();
        }

        [JsonConstructor]
        public GenericStateRepository(Dictionary<int, T> repository)
        {
            _repository = repository;
        }

        public virtual T GetState(int id)
        {
            _repository.TryGetValue(id, out T temp);

            return temp;
        }

        public virtual void UpdateState(T state)
        {
            var hasState = _repository.ContainsKey(state.Id);

            if (hasState)
            {
                _repository[state.Id] = state;
            }
            else
            {
                _repository.Add(state.Id, state);
            }
        }

        public T NewState()
        {
            int maxId = _repository.Max(x => x.Value.Id);
            int newId = maxId + 1;

            var newState = new T();
            newState.Id = newId;
            _repository.Add(newId, newState);

            _eventsDispatcher.Dispatch<NewStateEvent<T>>(new NewStateEvent<T>(newId));

            return newState;
        }
    }
}
