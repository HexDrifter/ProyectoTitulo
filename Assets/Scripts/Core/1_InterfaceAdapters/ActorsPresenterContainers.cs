using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class ActorsPresenterContainers
    {
        private Dictionary<string, ActorPresenter> _presenterToEntityID;

        public ActorsPresenterContainers()
        {
            _presenterToEntityID = new Dictionary<string, ActorPresenter>();
        }

        public void AddNewPresenter(string entityID, ActorPresenter presenter)
        {
            
            _presenterToEntityID.Add(entityID,presenter);
        }
    }
}
