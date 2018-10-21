using Duality;
using Duality.Resources;
using Singularity;
using Singularity.Bindings;
using System;
using System.Collections.Generic;

namespace DreamOfStars.Containers
{
    public class SingularityAdapter
    {
        public Container Container { get; private set; }
        private BindingConfig _config { get; set; }

        public SingularityAdapter()
        {
            Scene.ComponentAdded += OnComponentAdded;
            Scene.Entered += OnSceneEnter;
            Scene.Leaving += OnSceneLeave;

            _config = new BindingConfig();
        }

        public SingularityAdapter RegisterModule(IModule module)
        {
            module.Register(_config);

            return this;
        }

        public void InitializeContainer()
        {
            Container = new Container(_config);
        }

        public void OnGameEnd()
        {
            Scene.ComponentAdded -= OnComponentAdded;
            Scene.Entered -= OnSceneEnter;
            Scene.Leaving -= OnSceneLeave;
        }

        public void OnSceneEnter(object sender, EventArgs @event)
        {
            InjectGameObjects(Scene.Current.AllObjects);
        }

        public void OnSceneLeave(object sender, EventArgs @event)
        {
            
        }

        public void OnComponentAdded(object sender, ComponentEventArgs e)
        {
            Container.MethodInject(e.Component);
        }

        public void InjectGameObjects(IEnumerable<GameObject> gameObjects)
        {
            foreach (var gameObject in gameObjects)
            {
                Container.MethodInjectAll(gameObject.GetComponents<Component>());
            }
        }
    }
}
