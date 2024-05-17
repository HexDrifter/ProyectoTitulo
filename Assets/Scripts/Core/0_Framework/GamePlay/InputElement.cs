using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class InputElement
    {
        public readonly string Type;
        public readonly float ExitTime;

        public InputElement(string type, float exitTime)
        {
            Type = type;
            ExitTime = exitTime;
        }
    }
}
