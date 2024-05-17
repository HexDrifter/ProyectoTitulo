using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerActorBehavior : MonoBehaviour
    {
        [SerializeField] private string _id;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private float _moveSpeed = 3.0f;
        [SerializeField] private float _jumpForce = 5f;
        private Vector2 _inputDirection;

        public string ID  => _id;

        internal void SetInputDirection(Vector2 inputDirection)
        {
            _inputDirection = inputDirection;
        }
        public void Jump()
        {
            _rigidbody2D.AddForce(Vector3.up * _jumpForce, ForceMode2D.Impulse);
        }
        public void Update()
        {
            _rigidbody2D.AddForce((_inputDirection.x * _moveSpeed ) * Vector2.right, ForceMode2D.Force);
        }
    }
}
