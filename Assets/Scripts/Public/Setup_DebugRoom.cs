using ProyectoTitulo.Domain;
using ProyectoTitulo.Entities;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup_DebugRoom : MonoBehaviour
{
    private void Awake()
    {
        var actorRepository = ServiceLocator.Instance.GetService<IActorRepository>();
        var playerRepository = ServiceLocator.Instance.GetService<IPlayerRepository>();

        var actor0 = actorRepository.Add("Mario");
        var actor1 = actorRepository.Add("Luigi");
        playerRepository.currentPlayer.AddActor(new List<string>
        {
            actor0,
            actor1
        });

    }
    private void Start()
    {
        ServiceLocator.Instance.GetService<ShowAvailableActors>().Show();
    }
}
