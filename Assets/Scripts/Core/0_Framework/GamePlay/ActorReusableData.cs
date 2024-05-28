using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    [System.Serializable]

    public class ActorReusableData
    {
        [SerializeField] private float _decelerationForce = 3f;
        [SerializeField] private float _jumpForce = 15f;
        [SerializeField] private float _coyoteTime = 0.2f;

        

        public float DecelerationForce => _decelerationForce;
        public float JumpForce => _jumpForce;
        public float CoyoteTime => _coyoteTime;
        public bool isGrounded;
        public float timeInAir;

    }
}
