using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioActorBehavior : PlayerActorBehavior
{
    
    
    public override void Initialize(Animator animator)
    {
        base.Initialize(animator);

        var idleState = new PlayerActorIdleState(this);
        var walkingState = new PlayerActorWalkingState(this);
        var stoppingState = new PlayerActorStoppingState(this);
        var fallingState = new PlayerActorFallingState(this);
        var jumpingState = new PlayerActorJumpingState(this);
        AtLocomotion(idleState, walkingState, () => InputDirection!= Vector2.zero);
        AtLocomotion(idleState, jumpingState, () => ReusableData.isGrounded && CheckAndDequeueInput("jump"));
        AtLocomotion(idleState, fallingState, () => !ReusableData.isGrounded);

        AtLocomotion(walkingState, jumpingState, () => ReusableData.isGrounded && CheckAndDequeueInput("jump") );
        AtLocomotion(walkingState,stoppingState, () => InputDirection== Vector2.zero);
        AtLocomotion(walkingState, fallingState, () => !ReusableData.isGrounded);

        AtLocomotion(stoppingState,walkingState, () => InputDirection!= Vector2.zero);
        AtLocomotion(stoppingState, idleState, () => !stoppingState.IsMovingHorizontally());
        AtLocomotion(stoppingState, jumpingState, () => ReusableData.isGrounded && CheckAndDequeueInput("jump"));
        AtLocomotion(stoppingState, fallingState, () => !ReusableData.isGrounded);

        AtLocomotion(jumpingState, fallingState, () => jumpingState.ShouldFall());

        AtLocomotion(fallingState, idleState, () => ReusableData.isGrounded && InputDirection == Vector2.zero);
        AtLocomotion(fallingState, walkingState, () => ReusableData.isGrounded && InputDirection.magnitude > 0.2f);
        AtLocomotion(fallingState, jumpingState, () => CheckAndDequeueInput("jump") && ReusableData.timeInAir < ReusableData.CoyoteTime);

        _locomotionStateMachine.SetState(idleState);
    }
}
