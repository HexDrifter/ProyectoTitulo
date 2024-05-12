using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class SelectAvailableActorsPresenterContainers
    {
        private readonly SelectAvailableActorsContainerViewModel _viewModel;
        private Dictionary<string, ActorPresenter> _presenterToEntityID;

        public SelectAvailableActorsPresenterContainers(SelectAvailableActorsContainerViewModel viewModel)
        {

            _presenterToEntityID = new Dictionary<string, ActorPresenter>();
            _viewModel = viewModel;
        }

        public void AddNewPresenter(string entityID, ActorPresenter presenter)
        {
            
            _presenterToEntityID.Add(entityID,presenter);
        }
        public void Show(ShowContainerData data)
        {

            _viewModel.IsVisible.Value = data;
        }
        public void Hide(ShowContainerData data)
        {
            _viewModel.IsVisible.Value = data;
        }
    }
}
