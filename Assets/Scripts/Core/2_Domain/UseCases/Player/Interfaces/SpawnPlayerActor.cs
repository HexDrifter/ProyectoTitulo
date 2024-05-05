using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public interface SpawnPlayerActor
    {
        void Spawn(string actorEntityID, Vector3 position, Quaternion rotation);
    }
}
