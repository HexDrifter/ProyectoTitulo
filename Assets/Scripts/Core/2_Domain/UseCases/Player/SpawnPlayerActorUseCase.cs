using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public class SpawnPlayerActorUseCase : SpawnPlayerActor
    {
        private readonly IActorRepository _actorRepository;
        private readonly IActorBuilder _actorBuilder;
        private readonly ShowAvailableActorsOutput _showAvailableActorsOutput;
        private readonly DebugRoomConfigurationData _configurationData;

        public SpawnPlayerActorUseCase(IActorRepository actorRepository,
                                       IActorBuilder actorBuilder,
                                       ShowAvailableActorsOutput showAvailableActorsOutput,
                                       DebugRoomConfigurationData configurationData)
        {
            _actorRepository = actorRepository;
            _actorBuilder = actorBuilder;
            _showAvailableActorsOutput = showAvailableActorsOutput;
            _configurationData = configurationData;
        }

        public void Spawn(string actorEntityID, Vector3 position, Quaternion rotation)
        {
            var actor = _actorRepository.Get(actorEntityID);
            _actorBuilder
                .FromBehavior(actor.BaseID)
                .WithView(actor.ViewID)
                .Build(position,rotation);
            _showAvailableActorsOutput.Hide(new ShowContainerData(false,_configurationData.HideAvailableActorsContainerTime));
        }
    }
}
