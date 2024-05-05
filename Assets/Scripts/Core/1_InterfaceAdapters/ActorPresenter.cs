using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class ActorPresenter
    {
        private readonly ActorViewModel _viewModel;

        public ActorPresenter(ActorViewModel viewModel)
        {
            _viewModel = viewModel;
        }
    }
}
