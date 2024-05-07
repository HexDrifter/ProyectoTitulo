using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ActorsDatabase : ScriptableObject
    {
        [SerializeField] private List<ActorConfiguration> _actors = new List<ActorConfiguration>();
        [SerializeField] private Dictionary<string, ActorConfiguration> _actorsMap;

        public void Preload()
        {
            _actorsMap = new Dictionary<string, ActorConfiguration>();
            foreach (var actor in _actors)
            {
                _actorsMap.Add(actor.baseID, actor);
            }
        }
        public ActorConfiguration Get(string baseID)
        { 
            return _actorsMap[baseID];
        }
    }
}
