using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public class ShowAvailableActorsUseCase : ShowAvailableActors
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IActorRepository _actorRepository;
        private readonly ShowAvailableActorsOutput _output;
        private readonly DebugRoomConfigurationData _configurationData;

        public ShowAvailableActorsUseCase(IPlayerRepository playerRepository,
                                          IActorRepository actorRepository,
                                          ShowAvailableActorsOutput output,
                                          DebugRoomConfigurationData configurationData)
        {
            _playerRepository = playerRepository;
            _actorRepository = actorRepository;
            _output = output;
            _configurationData = configurationData;
        }

        public void Show()
        {

            var actorsToShow    = new List<AvailableActorsData>();
            var allActors       = _playerRepository.currentPlayer.availableActors;
            foreach (var actorEntityID in allActors)
            {
                var actor       = _actorRepository.Get(actorEntityID);
                actorsToShow    .Add(new AvailableActorsData(actor.EntityID,actor.BaseID));
            }
            _output.Show(actorsToShow, new ShowContainerData(true,
                                                             _configurationData.ShowAvailableActorsContainerTime));
        }
    }
}
