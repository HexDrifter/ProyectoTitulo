using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerHandler
    {
        private InputBuffer         _buffer;
        private PlayerActorBehavior _activeActor;
        private Vector2             _inputDirection;
        private bool                _jumpInput;
        
        public PlayerActorBehavior  activeActor     => _activeActor;
        public InputBuffer          inputBuffer     => _buffer;
        public Vector2              inputDirection  => _inputDirection;
        public bool                 jumpInput       => _jumpInput;

        public void SetInputJump(bool jumpInput)
        {
            _jumpInput = jumpInput;
        }

        public PlayerHandler()
        {
            _buffer = new InputBuffer();
        }

        public void SetActor(PlayerActorBehavior activeActor)
        {
            _activeActor = activeActor;
        }

        public void SetInputDirection(Vector2 inputDirection)
        {
            _inputDirection = inputDirection;
        }
        public void Tick()
        {

            if (_activeActor == null) return;
            _buffer.Tick();
            _activeActor.SetInputDirection(_inputDirection);
            _activeActor.SetInputJump(_jumpInput);
            
        }
    }
}
