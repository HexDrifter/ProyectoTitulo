using ProyectoTitulo.Domain;
using ProyectoTitulo.Framework;
using ProyectoTitulo.InterfaceAdapters;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreInstaller : MonoBehaviour
{
    [SerializeField] private ActorsDatabase _actorsDatabase;
    private void Awake()
    {
        var playerRepository = new PlayerRepository();
        var actorRepository = new ActorRepository();


        ServiceLocator.Instance.RegisterService<IPlayerRepository>(playerRepository);
        ServiceLocator.Instance.RegisterService<IActorRepository>(actorRepository);

        _actorsDatabase.Preload();

        ServiceLocator.Instance.RegisterService<ActorsDatabase>(_actorsDatabase);
        
    }
}
