using ProyectoTitulo.Domain;
using ProyectoTitulo.Entities;
using ProyectoTitulo.Framework;
using ProyectoTitulo.InterfaceAdapters;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_DebugRoom : MonoBehaviour, ILevelSetup
{
    [SerializeField] private ScriptableDebugRoomConfiguration _debugRoomConfiguration;
    [SerializeField] private ActorBehaviorFactoryConfiguration _actorBehaviorFactoryConfiguration;
    [SerializeField] private ActorViewFactoryConfiguration _actorViewFactoryConfiguration;
    [SerializeField] private ActorSelectButtonView _actorSelectButtonView;
    [SerializeField] private Transform _actorSelectButtonsContainer;
    [SerializeField] private SelectAvailableActorsContainerView _availableActorsContainerView;
    [SerializeField] private Transform _spawnPosition;

    public Transform SpawnPosition => _spawnPosition;

    private void Awake()
    {
        ServiceLocator.Instance.RegisterService<ILevelSetup>(this);
        _actorBehaviorFactoryConfiguration.Preload();
        _actorViewFactoryConfiguration.Preload();
        var actorRepository = ServiceLocator.Instance.GetService<IActorRepository>();
        var playerRepository = ServiceLocator.Instance.GetService<IPlayerRepository>();

        var actor0 = actorRepository.Add("mario", "Mario");
        var actor1 = actorRepository.Add("luigi", "Luigi");
        playerRepository.currentPlayer.AddActor(new List<string>
        {
            actor0,
            actor1
        });

        var selectAvailableActorsViewModel = new SelectAvailableActorsContainerViewModel(new ShowContainerData(false,0));
        _availableActorsContainerView.SetModel(selectAvailableActorsViewModel);

        var actorsPresenterContainer = new SelectAvailableActorsPresenterContainers(selectAvailableActorsViewModel);
        var actorSelectButtonInstantiatorGateway = new ActorSelectButtonInstantiatorGateway(actorsPresenterContainer,
                                                                                            _actorSelectButtonView,
                                                                                            _actorSelectButtonsContainer);
        var showAvailableActorsUseCase = new ShowAvailableActorsUseCase(playerRepository,
                                                                        actorRepository,
                                                                        actorSelectButtonInstantiatorGateway,
                                                                        _debugRoomConfiguration.ConfigurationData);
        ServiceLocator.Instance.RegisterService<ShowAvailableActors>(showAvailableActorsUseCase);
        var actorBehaviorFactory = new ActorBehaviorFactory(_actorBehaviorFactoryConfiguration);
        var actorViewFactory = new ActorViewFactory(_actorViewFactoryConfiguration);
        var actorBuilder = new ActorBuilder(actorBehaviorFactory, actorViewFactory);
        var spawnPlayerActorUseCase = new SpawnPlayerActorUseCase(actorRepository,
                                                                  actorBuilder,
                                                                  actorSelectButtonInstantiatorGateway,
                                                                  _debugRoomConfiguration.ConfigurationData);

        ServiceLocator.Instance.RegisterService<SpawnPlayerActor> (spawnPlayerActorUseCase);
    }
    private void Start()
    {
        ServiceLocator.Instance.GetService<ShowAvailableActors>().Show();
        

    }
    

}
