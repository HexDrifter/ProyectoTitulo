using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    using Domain;
    using Entities;

    public class PlayerRepository : IPlayerRepository
    {
        private readonly Player _player;
        public Player current => _player;

        public PlayerRepository()
        {
            _player = new Player();
        }
    }
}
