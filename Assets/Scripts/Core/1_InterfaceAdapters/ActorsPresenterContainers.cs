using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class ActorsPresenterContainers : ShowAvailableActorsOutput
    {
        private Dictionary<string, ActorPresenter> _presenterToEntityID;

        public ActorsPresenterContainers()
        {
            _presenterToEntityID = new Dictionary<string, ActorPresenter>();
        }

        public void Show(List<AvailableActorsData> availableActorsData)
        {
            foreach(var availableActorData in availableActorsData)
            {
                AddNewPresenter(availableActorData);
            }
        }

        private void AddNewPresenter(AvailableActorsData availableActorData)
        {
            var actorViewModel = new ActorViewModel(availableActorData.ActorBaseID);
            var actorPresenter = new ActorPresenter(actorViewModel);
            _presenterToEntityID.Add(availableActorData.ActorEntityID, actorPresenter);
        }
    }
}
