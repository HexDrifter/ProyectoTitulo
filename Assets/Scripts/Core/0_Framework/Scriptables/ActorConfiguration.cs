using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ActorConfiguration : ScriptableObject
    {
        [SerializeField] private string _baseID;
        [SerializeField] private string _actorName;
        public string actorName => _actorName;
        public string baseID => _baseID;
    }
}
