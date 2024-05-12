using ProyectoTitulo.Domain;
using ProyectoTitulo.InterfaceAdapters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorSelectButtonInstantiatorGateway : ShowAvailableActorsOutput
    {
        private readonly SelectAvailableActorsPresenterContainers _selectAvailableActorsPresenterContainers;
        private readonly ActorSelectButtonView _actorSelectButtonView;
        private readonly Transform _actorSelectButtonsContainerTransform;

        public ActorSelectButtonInstantiatorGateway(SelectAvailableActorsPresenterContainers actorsPresenterContainers,
                                                    ActorSelectButtonView actorSelectButtonView,
                                                    Transform actorSelectButtonsContainer)
        {
            _selectAvailableActorsPresenterContainers = actorsPresenterContainers;
            _actorSelectButtonView = actorSelectButtonView;
            _actorSelectButtonsContainerTransform = actorSelectButtonsContainer;
        }

        public void Hide(ShowContainerData data)
        {
            _selectAvailableActorsPresenterContainers.Hide(data);
        }

        public void Show(List<AvailableActorsData> availableActorsData, ShowContainerData data)
        {
            foreach (var actorData in availableActorsData)
            {
                var actorViewModel = new ActorViewModel(actorData.ActorEntityID, actorData.ActorBaseID);
                var actorPresenter = new ActorPresenter(actorViewModel);
                _selectAvailableActorsPresenterContainers.AddNewPresenter(actorData.ActorEntityID, actorPresenter);
                var ViewInstance = Object.Instantiate(_actorSelectButtonView,
                                                      _actorSelectButtonsContainerTransform);
                ViewInstance.SetModel(actorViewModel);
            }
            _selectAvailableActorsPresenterContainers.Show(data);
        }

    }
}
