using ProyectoTitulo.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerActorBehavior : MonoBehaviour
    {
        protected StateMachine _locomotionStateMachine;
        [SerializeField] private ActorReusableData _actorReusableData;
        [SerializeField] private string _id;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private float _moveSpeed = 3.0f;
        [SerializeField] private float _jumpForce = 5f;
        private Vector2 _inputDirection;

        public string ID  => _id;
        public Rigidbody2D Rigidbody2D => _rigidbody2D;
        public float MoveSpeed => _moveSpeed;
        public float JumpForce => _jumpForce;
        public Vector2 InputDirection => _inputDirection;
        public ActorReusableData ReusableData => _actorReusableData;


        protected string AtLocomotion(IState from, IState to, Func<bool> condition) => _locomotionStateMachine.AddTransition(from, to,condition);

        protected virtual void Awake()
        {
            _locomotionStateMachine = new StateMachine();
        }

        private void Update()
        {
            _locomotionStateMachine.Tick();
        }
        private void FixedUpdate()
        {
            _locomotionStateMachine.PhysicsTick();
        }
        internal void SetInputDirection(Vector2 inputDirection)
        {
            _inputDirection = inputDirection;
        }
        public void Jump()
        {
            _rigidbody2D.AddForce(Vector3.up * _jumpForce, ForceMode2D.Impulse);
        }


    }
}
