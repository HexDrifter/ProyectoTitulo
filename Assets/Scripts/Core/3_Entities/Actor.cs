using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Entities
{
    public class Actor
    {
        public readonly string EntityID;
        public readonly string BaseID;
        public readonly string ViewID;

        public Actor(string entityID, string baseID, string viewID)
        {
            EntityID = entityID;
            BaseID = baseID;
            ViewID = viewID;
        }
    }
}
