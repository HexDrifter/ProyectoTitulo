using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public struct AvailableActorsData
    {
        public readonly string ActorEntityID;
        public readonly string ActorBaseID;

        public AvailableActorsData(string actorEntityID, string actorBaseID)
        {
            ActorEntityID = actorEntityID;
            ActorBaseID = actorBaseID;
        }
    }
}
