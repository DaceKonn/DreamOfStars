using DreamOfStars.StateRepositories;
using Newtonsoft.Json;
using Singularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamOfStars.States
{
    public sealed class ProvidedState<T> where T : AbstractState
    {
        private int _stateId = 0;

        [JsonIgnore]
        private IGenericStateRepository<T> _stateRepository;
        [JsonIgnore]
        private T _state;


        [Inject]
        public void Inject(IGenericStateRepository<T> stateRepository)
        {
            _stateRepository = stateRepository;
        }

        [JsonConstructor]
        public ProvidedState(int stateId = 0)
        {
            _stateId = stateId;
        }

        public ProvidedState(IGenericStateRepository<T> stateRepository, int stateId = 0)
        {
            Inject(stateRepository);
            _stateId = stateId;
        }

        [JsonIgnore]
        public T State
        {
            get
            {
                if (_state != null)
                {
                    return _state;
                }
                else if (_stateId > 0)
                {
                    _state = _stateRepository.GetState(_stateId);
                }

                _state = _stateRepository.NewState();
                _stateId = _state.Id;
                return _state;
            }
        }
    }
}
