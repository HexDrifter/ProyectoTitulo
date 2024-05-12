using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ActorBehaviorFactoryConfiguration : ScriptableObject
    {
        [SerializeField] private List<PlayerActorBehavior> _actorBehaviors = new List<PlayerActorBehavior>() ;
        private Dictionary<string, PlayerActorBehavior> _actorsMap;

        public void Preload()
        {
            _actorsMap = new Dictionary<string, PlayerActorBehavior>();

            foreach (var behavior in _actorBehaviors)
            {
                _actorsMap.Add(behavior.ID, behavior);
            }

        }

        public PlayerActorBehavior Get(string id)
        {
            return _actorsMap[id];
        }
    }
}
