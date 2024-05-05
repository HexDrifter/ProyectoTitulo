using ProyectoTitulo.Domain;
using ProyectoTitulo.Framework;
using ProyectoTitulo.InterfaceAdapters;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreInstaller : MonoBehaviour
{
    private void Awake()
    {
        var playerRepository = new PlayerRepository();
        var actorRepository = new ActorRepository();

        ServiceLocator.Instance.RegisterService<IPlayerRepository>(playerRepository);
        ServiceLocator.Instance.RegisterService<IActorRepository>(actorRepository);


        var actorsPresenterContainer = new ActorsPresenterContainers();
        var showAvailableActorsUseCase = new ShowAvailableActorsUseCase(playerRepository,
                                                                        actorRepository,
                                                                        actorsPresenterContainer);
        ServiceLocator.Instance.RegisterService<ShowAvailableActors>(showAvailableActorsUseCase);
    }
}
