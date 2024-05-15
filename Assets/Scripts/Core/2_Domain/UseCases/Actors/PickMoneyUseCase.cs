using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Domain
{
    public class PickMoneyUseCase : PickMoney
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly PlayerMoneyOutput _moneyOutput;
        private readonly PlayerLifesOutput _lifesOutput;

        public PickMoneyUseCase(IPlayerRepository playerRepository,
                                PlayerMoneyOutput moneyOutput,
                                PlayerLifesOutput lifesOutput)
        {
            _playerRepository = playerRepository;
            _moneyOutput = moneyOutput;
            _lifesOutput = lifesOutput;
        }

        public void Pick(int quantity)
        {
            var player = _playerRepository.currentPlayer;
            player.AddMoney(quantity);

            _moneyOutput.ShowMoney(player.money);
            _lifesOutput.ShowLifes(player.lifes);
        }
    }
}
