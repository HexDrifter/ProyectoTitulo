using ProyectoTitulo.Domain;
using ProyectoTitulo.SystemUtilities;
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
        [SerializeField] private LayerMask _groundLayer;
        private Vector2 _inputDirection;
        private bool _inputJump;
        private RaycastHit2D _groundedHit;
        private Animator _viewAnimator;
        public Animator ViewAnimator => _viewAnimator;

        public string ID  => _id;
        public Rigidbody2D Rigidbody2D => _rigidbody2D;
        public float MoveSpeed => _moveSpeed;
        public float JumpForce => _jumpForce;
        public bool inputJump => _inputJump;
        public Vector2 InputDirection => _inputDirection;
        public ActorReusableData ReusableData => _actorReusableData;




        protected string AtLocomotion(IState from, IState to, Func<bool> condition) => _locomotionStateMachine.AddTransition(from, to,condition);

        public virtual void Initialize(Animator animator)
        {
            
            _locomotionStateMachine = new StateMachine();
            _viewAnimator = animator;
        }
        

        private void Update()
        {
            IsGrounded();
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
        internal void SetInputJump(bool inputJump)
        {
            _inputJump = inputJump;
        }
        protected bool CheckAndDequeueInput(string input)
        {
            var peek = ServiceLocator.Instance.GetService<PlayerHandler>().inputBuffer.Peek(input);
            if (peek)
            {
                ServiceLocator.Instance.GetService<PlayerHandler>().inputBuffer.Remove();
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void IsGrounded()
        {
            _groundedHit = Physics2D.BoxCast(transform.position + Vector3.up * 0.05f, new Vector2(0.5f,0.1f),0f,Vector2.down,0.05f,_groundLayer);

            //if (Physics2D.CircleCast(transform.position + (Vector3.up * 0.15f),0.16f,Vector3.down,0.15f,_groundLayer))
            if (_groundedHit.collider!=null)
            {
                _actorReusableData.isGrounded = true;
            }
            else
            {
                _actorReusableData.isGrounded = false;
            }


        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireCube(transform.position + Vector3.up * 0.05f, new Vector3(0.5f,0.1f,0f));
            if(_locomotionStateMachine != null)
            {
                Gizmos.color = _locomotionStateMachine.GetGizmoColor();
                Gizmos.DrawWireSphere(transform.position + ( Vector3.up * 1.5f), 0.2f);
            }
            
        }
    }
}
