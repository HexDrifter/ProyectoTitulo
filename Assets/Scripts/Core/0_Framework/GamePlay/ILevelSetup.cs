using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public interface ILevelSetup
    {
        Transform SpawnPosition { get; }
    }
}
