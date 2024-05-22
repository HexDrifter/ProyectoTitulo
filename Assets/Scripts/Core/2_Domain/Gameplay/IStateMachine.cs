using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public interface IStateMachine
    {
        void Tick();
        void PhysicsTick();
    }
}
