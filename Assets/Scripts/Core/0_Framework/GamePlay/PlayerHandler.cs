using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerHandler
    {
        private InputBuffer _buffer;
        private PlayerActorBehavior _activeActor;
        private Vector2 _inputDirection;
        

        public PlayerActorBehavior activeActor => _activeActor;
        public InputBuffer inputBuffer => _buffer;
        public Vector2 inputDirection => _inputDirection;

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
            if (_buffer.Peek("jump"))
            {
                _buffer.Remove();
                _activeActor.Jump();
            }
        }
    }
}
