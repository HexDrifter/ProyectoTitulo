using ProyectoTitulo.Domain;
using ProyectoTitulo.Framework;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Profiling.HierarchyFrameDataView;

public class SpawnPlayerActorController : MonoBehaviour
{
    
    private void Awake()
    {
        ServiceLocator.Instance.RegisterService<SpawnPlayerActorController>(this);
        

    }

    public void SpawnPlayerActor(string entityID)
    {

        var spawnPosition = ServiceLocator.Instance.GetService<ILevelSetup>()
                .SpawnPosition;

        ServiceLocator.Instance.GetService<SpawnPlayerActor>()
        .Spawn(entityID,
               spawnPosition.position,
               spawnPosition.rotation);
        var spawnedActor  = ServiceLocator.Instance.GetService<ActorBuilder>().Get(entityID);
        ServiceLocator.Instance.GetService<PlayerHandler>().SetActor(spawnedActor);
        ServiceLocator.Instance.GetService<GameInput>().Actor.Enable();

    }
}
