using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    [System.Serializable]
    public class DebugRoomConfigurationData 
    {
        [SerializeField] private float _showAvailableActorsContainerTime = 0.25f;
        [SerializeField] private float _hideAvailableActorsContainerTime = 0.5f;
        public float ShowAvailableActorsContainerTime => _showAvailableActorsContainerTime;

        public float HideAvailableActorsContainerTime => _hideAvailableActorsContainerTime;
    }
}
