using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ActorViewFactoryConfiguration : ScriptableObject
    {
        [SerializeField] private List<PlayerActorView> _actors = new List<PlayerActorView>();
        private Dictionary<string, PlayerActorView> _actorsMap;

        public void Preload()
        {
            _actorsMap = new Dictionary<string, PlayerActorView>();
            foreach (var actor in _actors)
            {
                _actorsMap.Add(actor.ID, actor);
            }
        }
        public PlayerActorView Get(string viewID)
        {
            return _actorsMap[viewID];
        }
    }
}
