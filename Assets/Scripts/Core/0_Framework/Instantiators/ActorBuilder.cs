using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorBuilder : IActorBuilder
    {
        private readonly ICameraService _cameraService;
        private readonly ActorBehaviorFactory _actorBehaviorFactory;
        private readonly ActorViewFactory _viewFactory;
        private string _behaviorID;
        private string _viewID;
        private Dictionary<string, PlayerActorBehavior> _spawnedBehaviors;


        public ActorBuilder(ActorBehaviorFactory actorBehaviorFactory,
                            ActorViewFactory viewFactory,
                            ICameraService cameraService)
        {
            _actorBehaviorFactory = actorBehaviorFactory;
            _viewFactory = viewFactory;
            _spawnedBehaviors = new Dictionary<string, PlayerActorBehavior>();
            _cameraService = cameraService;
        }

        public void Build(string entityID, Vector3 position, Quaternion rotation)
        {
            Debug.Log("Instanciando personaje.");
            var behaviorInstance = _actorBehaviorFactory.Create(_behaviorID, position, rotation);
            var viewInstance = _viewFactory.Create(_viewID,behaviorInstance.transform);
            _spawnedBehaviors.Add(entityID,behaviorInstance);
            _cameraService.TargetActor(behaviorInstance.transform);
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

        public PlayerActorBehavior Get(string entityID)
        {
            return _spawnedBehaviors[entityID];
        }
    }
}
