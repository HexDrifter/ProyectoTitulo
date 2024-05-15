using ProyectoTitulo.Domain;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class PlayerPresenter : PlayerMoneyOutput, PlayerLifesOutput
    {
        private readonly PlayerViewModel _playerViewModel;
        public PlayerPresenter(PlayerViewModel playerViewModel)
        {  
            _playerViewModel = playerViewModel;
        }

        public void ShowLifes(int quantity)
        {
            _playerViewModel.Lifes.Value = quantity;
        }

        public void ShowMoney(int quantity)
        {
            _playerViewModel.Money.Value = quantity;
        }
    }
}
