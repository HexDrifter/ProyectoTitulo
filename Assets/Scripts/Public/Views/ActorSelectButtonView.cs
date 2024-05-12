using ProyectoTitulo.InterfaceAdapters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;
using System;
using ProyectoTitulo.SystemUtilities;
using UnityEngine.UI;
using ProyectoTitulo.Domain;

namespace ProyectoTitulo.Framework
{
    public class ActorSelectButtonView : BaseReactiveView
    {
        [SerializeField] private Button _button_selectActor;
        [SerializeField] private TextMeshProUGUI _text_actorName;
        [SerializeField] private Image _image_portrait;
        
        private ActorViewModel _viewModel;


        private void Awake()
        {
            _button_selectActor.onClick.RemoveAllListeners();
            _button_selectActor.onClick.AddListener(() =>
            {
                ServiceLocator
                .Instance
                .GetService<SpawnPlayerActor>()
                .Spawn(_viewModel.EntityID,
                       Vector3.zero,
                       Quaternion.identity);
            });
        }


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
            _text_actorName.text = config.Data.actorName;
            _image_portrait.sprite = config.Data.selectableSprite;
        }

    }
}
