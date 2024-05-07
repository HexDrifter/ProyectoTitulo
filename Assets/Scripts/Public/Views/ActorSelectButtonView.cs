using ProyectoTitulo.InterfaceAdapters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;
using System;
using ProyectoTitulo.SystemUtilities;

namespace ProyectoTitulo.Framework
{
    public class ActorSelectButtonView : BaseReactiveView
    {
        [SerializeField] private TextMeshProUGUI _text_actorName;
        private ActorViewModel _viewModel;


        public void SetModel(ActorViewModel model)
        {
            _viewModel = model;
            _viewModel
                .BaseID
                .Subscribe(OnUpdateBaseID)
                .AddTo(_disposables);
        }

        private void OnUpdateBaseID(string baseID)
        {
            var config = ServiceLocator.Instance.GetService<ActorsDatabase>().Get(baseID);
            _text_actorName.text = config.actorName;
        }

    }
}
