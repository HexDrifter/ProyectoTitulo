using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorBehaviorFactory
    {
        private readonly ActorBehaviorFactoryConfiguration _configuration;

        public ActorBehaviorFactory(ActorBehaviorFactoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public PlayerActorBehavior Create(string ID, Vector3 position, Quaternion rotation)
        {
            var behaviorInstance = Object.Instantiate(_configuration.Get(ID), position, rotation);
            return behaviorInstance;
        }
    }
}
