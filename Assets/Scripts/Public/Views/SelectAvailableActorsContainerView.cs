using DG.Tweening;
using ProyectoTitulo.Framework;
using ProyectoTitulo.InterfaceAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class SelectAvailableActorsContainerView : BaseReactiveView
{
    [SerializeField] private CanvasGroup _visibilityCanvas;
    private SelectAvailableActorsContainerViewModel _viewModel;
    private Sequence _visibilitySequence;

    private void Awake()
    {
        _visibilitySequence = DOTween.Sequence();
    }
    public void SetModel(SelectAvailableActorsContainerViewModel viewModel)
    {
        _viewModel = viewModel;

        _viewModel
            .IsVisible
            .Where((x) => x.Visibility == true)
            .Subscribe(x =>
            {
                _visibilityCanvas.gameObject.SetActive(true);
                _visibilityCanvas.blocksRaycasts = true;
                _visibilityCanvas.interactable = false;
                _visibilitySequence.Kill();
                _visibilitySequence = DOTween.Sequence();
                _visibilitySequence.Append(
                _visibilityCanvas.DOFade(1, x.TransitionTime).OnComplete(() =>
                {
                    _visibilityCanvas.interactable = true;
                }));

            })
            .AddTo(_disposables);

        _viewModel
            .IsVisible
            .Where((x) => x.Visibility == false)
            .Subscribe(x =>
            {
                _visibilityCanvas.interactable = false;
                _visibilityCanvas.blocksRaycasts = true;

                _visibilitySequence.Kill();
                _visibilitySequence = DOTween.Sequence();
                _visibilitySequence.Append(
                _visibilityCanvas.DOFade(0, x.TransitionTime).OnComplete(() =>
                {
                    _visibilityCanvas.blocksRaycasts = false;
                    _visibilityCanvas.gameObject.SetActive(false);
                }));
            })
            .AddTo(_disposables);

    }

}
