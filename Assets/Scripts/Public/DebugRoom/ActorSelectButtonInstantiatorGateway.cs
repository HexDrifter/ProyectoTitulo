using ProyectoTitulo.Domain;
using ProyectoTitulo.InterfaceAdapters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorSelectButtonInstantiatorGateway : ShowAvailableActorsOutput
    {
        private readonly ActorsPresenterContainers _actorsPresenterContainers;
        private readonly ActorSelectButtonView _actorSelectButtonView;
        private readonly Transform _ActorSelectButtonsContainer;

        public ActorSelectButtonInstantiatorGateway(ActorsPresenterContainers actorsPresenterContainers,
                                                    ActorSelectButtonView actorSelectButtonView,
                                                    Transform actorSelectButtonsContainer)
        {
            _actorsPresenterContainers = actorsPresenterContainers;
            _actorSelectButtonView = actorSelectButtonView;
            _ActorSelectButtonsContainer = actorSelectButtonsContainer;
        }

        public void Show(List<AvailableActorsData> availableActorsData)
        {
            foreach (var actorData in availableActorsData)
            {
                var actorViewModel = new ActorViewModel(actorData.ActorEntityID, actorData.ActorBaseID);
                var actorPresenter = new ActorPresenter(actorViewModel);
                _actorsPresenterContainers.AddNewPresenter(actorData.ActorEntityID, actorPresenter);
                var ViewInstance = Object.Instantiate(_actorSelectButtonView,
                                                      _ActorSelectButtonsContainer);
                ViewInstance.SetModel(actorViewModel);
            }
        }
    }
}
