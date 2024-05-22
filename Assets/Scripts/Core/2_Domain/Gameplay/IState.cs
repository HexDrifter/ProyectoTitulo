using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public interface IState
    {
        void Tick();
        void PhysicsTick();
        void OnEnter();
        void OnExit();
        Color GizmoColor();
    }
}
