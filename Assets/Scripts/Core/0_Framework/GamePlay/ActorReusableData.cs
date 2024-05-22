using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [System.Serializable]

    public class ActorReusableData
    {
        [SerializeField] private float _decelerationForce = 3f;
        public float DecelerationForce => _decelerationForce;


    }
}
