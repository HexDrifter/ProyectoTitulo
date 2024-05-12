using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ActorConfiguration : ScriptableObject
    {
        [SerializeField] private string _baseID;
        [SerializeField] private ActorConfigurationData _data;
        public string baseID => _baseID;
        public ActorConfigurationData Data => _data;

    }
}
