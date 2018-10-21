using DreamOfStars.States;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace DreamOfStars.StateRepositories.Implementation
{
    public class GenericStateRepository<T> : IGenericStateRepository<T> where T : AbstractState
    {
        
        private Dictionary<int, T> _repository { get; set; }

        public GenericStateRepository()
        {
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
    }
}
