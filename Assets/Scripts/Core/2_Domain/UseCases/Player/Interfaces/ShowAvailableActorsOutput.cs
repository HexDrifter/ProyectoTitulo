using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public interface ShowAvailableActorsOutput
    {
        void Hide(ShowContainerData data);
        void Show(List<AvailableActorsData> availableActorsData, ShowContainerData data);

    }
}
