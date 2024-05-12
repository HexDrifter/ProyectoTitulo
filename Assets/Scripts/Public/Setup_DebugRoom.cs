using ProyectoTitulo.Domain;
using ProyectoTitulo.Entities;
using ProyectoTitulo.Framework;
using ProyectoTitulo.InterfaceAdapters;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_DebugRoom : MonoBehaviour
{
    [SerializeField] private ActorSelectButtonView _actorSelectButtonView;
    [SerializeField] private Transform _actorSelectButtonsContainer;
    private void Awake()
    {
        var actorRepository = ServiceLocator.Instance.GetService<IActorRepository>();
        var playerRepository = ServiceLocator.Instance.GetService<IPlayerRepository>();

        var actor0 = actorRepository.Add("mario", "0");
        var actor1 = actorRepository.Add("luigi", "0");
        playerRepository.currentPlayer.AddActor(new List<string>
        {
            actor0,
            actor1
        });
        var actorsPresenterContainer = new ActorsPresenterContainers();
        var actorSelectButtonInstantiatorGateway = new ActorSelectButtonInstantiatorGateway(actorsPresenterContainer, _actorSelectButtonView, _actorSelectButtonsContainer);
        var showAvailableActorsUseCase = new ShowAvailableActorsUseCase(playerRepository,
                                                                        actorRepository,
                                                                        actorSelectButtonInstantiatorGateway);
        ServiceLocator.Instance.RegisterService<ShowAvailableActors>(showAvailableActorsUseCase);
        var actorBehaviorFactory = new ActorBehaviorFactory();
        var actorViewFactory = new ActorViewFactory();
        var actorBuilder = new ActorBuilder(actorBehaviorFactory, actorViewFactory);
        var spawnPlayerActorUseCase = new SpawnPlayerActorUseCase(actorRepository, actorBuilder);

        ServiceLocator.Instance.RegisterService<SpawnPlayerActor> (spawnPlayerActorUseCase);
    }
    private void Start()
    {
        ServiceLocator.Instance.GetService<ShowAvailableActors>().Show();

    }

}
