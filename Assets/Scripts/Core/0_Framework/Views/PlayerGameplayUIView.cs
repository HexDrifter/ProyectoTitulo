using ProyectoTitulo.InterfaceAdapters;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UniRx;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerGameplayUIView : BaseReactiveView
    {
        [SerializeField] private TextMeshProUGUI _text_money_value;
        [SerializeField] private TextMeshProUGUI _text_lifes_value;
        private PlayerViewModel _playerViewModel;
        public void SetModel(PlayerViewModel model)
        { 
            _playerViewModel = model;

            _playerViewModel
                .Money
                .Subscribe((moneys) =>
                {
                    _text_money_value.text = moneys.ToString();
                })
                .AddTo(_disposables);
            
            _playerViewModel
                .Lifes
                .Subscribe((lifes) =>
                {
                    _text_lifes_value.text = lifes.ToString();
                })
                .AddTo(_disposables);

        }
    }
}
