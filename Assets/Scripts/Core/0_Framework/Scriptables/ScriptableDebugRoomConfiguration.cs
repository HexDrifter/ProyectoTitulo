using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [CreateAssetMenu]
    public class ScriptableDebugRoomConfiguration : ScriptableObject
    {
        [SerializeField] private DebugRoomConfigurationData _configurationData;

        public DebugRoomConfigurationData ConfigurationData => _configurationData;
    }
}
