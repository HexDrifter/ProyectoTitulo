using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioActorBehavior : PlayerActorBehavior
{
    protected override void Awake()
    {
        base.Awake();
        var idleState = new PlayerActorIdleState(this);
        var walkingState = new PlayerActorWalkingState(this);
        var stoppingState = new PlayerActorStoppingState(this);

        AtLocomotion(idleState, walkingState, () => InputDirection!= Vector2.zero);
        AtLocomotion(walkingState,stoppingState, () => InputDirection== Vector2.zero);
        AtLocomotion(stoppingState,walkingState, () => InputDirection!= Vector2.zero);
        AtLocomotion(stoppingState, idleState, () => !stoppingState.IsMovingHorizontally());
        _locomotionStateMachine.SetState(idleState);
    }
}
