using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class SelectAvailableActorsContainerViewModel
    {
        public ReactiveProperty<ShowContainerData> IsVisible;

        public SelectAvailableActorsContainerViewModel(ShowContainerData initialVisibility)
        {
            IsVisible = new ReactiveProperty<ShowContainerData>(initialVisibility);
        }
    }
}
