using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public class PickLifeUseCase : PickLife
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly PlayerLifesOutput _output;

        public PickLifeUseCase(IPlayerRepository playerRepository, PlayerLifesOutput output)
        {
            _playerRepository = playerRepository;
            _output = output;
        }

        public void Pick(int quantity)
        {
            var player = _playerRepository.currentPlayer;
            player.AddLifes(quantity);
            _output.ShowLifes(player.lifes);
        }
    }
}
