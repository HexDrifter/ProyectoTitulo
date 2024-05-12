using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [System.Serializable]
    public class ActorConfigurationData
    {
        [SerializeField] private string _actorName;
        [SerializeField] private Sprite _selectableSprite;
        public string actorName => _actorName;

        public Sprite selectableSprite => _selectableSprite;
    }
}
