using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class ActorViewModel
    {
        public readonly string EntityID;
        public StringReactiveProperty BaseID;

        public ActorViewModel(string entityID, string baseID)
        {
            EntityID = entityID;
            BaseID = new StringReactiveProperty(baseID
                );
        }
    }
}
