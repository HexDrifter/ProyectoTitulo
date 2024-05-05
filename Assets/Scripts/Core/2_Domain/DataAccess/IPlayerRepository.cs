using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    using Entities;
    public interface IPlayerRepository
    {
        Player currentPlayer {  get; }
    }
}
