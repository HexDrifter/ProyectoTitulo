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
        private string _behaviorID;
        private string _viewID;

        public ActorBuilder(ActorBehaviorFactory actorBehaviorFactory,
                            ActorViewFactory viewFactory)
        {
            _actorBehaviorFactory = actorBehaviorFactory;
            _viewFactory = viewFactory;
        }

        public void Build(Vector3 position, Quaternion rotation)
        {
            Debug.Log("Instanciando personaje.");
            var behaviorInstance = _actorBehaviorFactory.Create(_behaviorID, position, rotation);
            var viewInstance = _viewFactory.Create(_viewID,behaviorInstance.transform);
        }

        public IActorBuilder FromBehavior(string behaviorID)
        {
            _behaviorID = behaviorID;
            return this;
        }

        public IActorBuilder WithView(string viewID)
        {
            _viewID = viewID;
            return this;
        }
    }
}
