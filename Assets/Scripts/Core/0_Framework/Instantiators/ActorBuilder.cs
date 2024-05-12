using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorBuilder : IActorBuilder
    {
        private readonly ActorBehaviorFactory _actorBehaviorFactory;
        private readonly ActorViewFactory _viewFactory;

        public ActorBuilder(ActorBehaviorFactory actorBehaviorFactory,
                            ActorViewFactory viewFactory)
        {
            _actorBehaviorFactory = actorBehaviorFactory;
            _viewFactory = viewFactory;
        }

        public void Build(Vector3 position, Quaternion rotation)
        {
            Debug.Log("Instanciando personaje.");
        }

        public IActorBuilder FromBehavior(string behaviorID)
        {
            return this;
        }

        public IActorBuilder WithView(string viewID)
        {
            return this;
        }
    }
}
