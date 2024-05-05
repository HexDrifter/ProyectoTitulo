using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Entities
{
    public class Actor
    {
        public readonly string EntityID;
        public readonly string BaseID;

        public Actor(string entityID, string baseID)
        {
            EntityID = entityID;
            BaseID = baseID;
        }
    }
}
