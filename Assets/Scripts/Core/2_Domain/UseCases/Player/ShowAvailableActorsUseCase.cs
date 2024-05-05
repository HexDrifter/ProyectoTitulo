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

        public ShowAvailableActorsUseCase(IPlayerRepository playerRepository,
                                          IActorRepository actorRepository,
                                          ShowAvailableActorsOutput output)
        {
            _playerRepository = playerRepository;
            _actorRepository = actorRepository;
            _output = output;
        }

        public void Show()
        {
            Debug.Log("Mostrando Actores");
            var actorsToShow = new List<AvailableActorsData>();
            var allActors = _playerRepository.currentPlayer.availableActors;
            foreach (var actorEntityID in allActors)
            {
                var actor = _actorRepository.Get(actorEntityID);
                actorsToShow.Add(new AvailableActorsData(actor.EntityID,actor.BaseID));
            }
            _output.Show(actorsToShow);
        }
    }
}
