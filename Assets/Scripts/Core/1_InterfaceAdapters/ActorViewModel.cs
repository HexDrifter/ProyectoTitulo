using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class ActorViewModel
    {
        public StringReactiveProperty BaseID;

        public ActorViewModel(string initialBaseID)
        {
            BaseID = new StringReactiveProperty(initialBaseID
                );
        }
    }
}
