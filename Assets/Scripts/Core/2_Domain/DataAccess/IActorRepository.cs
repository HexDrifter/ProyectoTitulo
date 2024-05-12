using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    using Entities;
    public interface IActorRepository
    {
        string Add(string baseID, string viewID);
        Actor Get(string entityID);
    }
}
