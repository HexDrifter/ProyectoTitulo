using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public struct ShowContainerData
    {
        public readonly bool Visibility;
        public readonly float TransitionTime;

        public ShowContainerData(bool visibility, float transitionTime)
        {
            Visibility = visibility;
            TransitionTime = transitionTime;
        }
    }
}
