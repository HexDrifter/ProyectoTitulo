using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class InputBuffer
    {
        private Queue<InputElement> _inputs;
        private float _bufferTime;
        private int _maxBufferLength;
        public int length => _inputs.Count;

        public InputBuffer(float bufferTime = 0.2f, int maxBufferLength = 10)
        {
            _bufferTime = bufferTime;
            _maxBufferLength = maxBufferLength;
            _inputs = new Queue<InputElement>();
        }

        public void Add(string type)
        {
            if (length > _maxBufferLength) return;

            _inputs.Enqueue(new InputElement(type, Time.time + _bufferTime));
        }

        public void Remove()
        {
            if (_inputs.Count == 0) return;
            _inputs.Dequeue();
        }

        public bool Peek(string type)
        {
            if(_inputs.Count == 0) return false;
            if (_inputs.Peek().Type == type) return true;
            return false;
        }

        public void Tick()
        {
            if ( _inputs.Count > 0)
            {
                if(Time.time > _inputs.Peek().ExitTime)
                {
                    _inputs.Dequeue();
                }
            }
        }

    }
}
