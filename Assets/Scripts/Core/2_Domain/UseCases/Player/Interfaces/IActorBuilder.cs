using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public interface IActorBuilder
    {
        IActorBuilder FromBehavior(string behaviorID);
        IActorBuilder WithView(string viewID);
        void Build(string entityID, Vector3 position, Quaternion rotation);

        
    }
}
