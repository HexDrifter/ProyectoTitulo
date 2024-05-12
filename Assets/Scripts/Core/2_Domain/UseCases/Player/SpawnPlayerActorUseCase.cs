using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public class SpawnPlayerActorUseCase : SpawnPlayerActor
    {
        private readonly IActorRepository _actorRepository;
        private readonly IActorBuilder _actorBuilder;

        public SpawnPlayerActorUseCase(IActorRepository actorRepository,
                                       IActorBuilder actorBuilder)
        {
            _actorRepository = actorRepository;
            _actorBuilder = actorBuilder;
        }

        public void Spawn(string actorEntityID, Vector3 position, Quaternion rotation)
        {
            var actor = _actorRepository.Get(actorEntityID);
            _actorBuilder
                .FromBehavior(actor.BaseID)
                .WithView(actor.ViewID)
                .Build(position,rotation);
            
        }
    }
}
