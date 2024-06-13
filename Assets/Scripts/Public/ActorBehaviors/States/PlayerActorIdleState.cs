using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorIdleState : PlayerActorGroundedState
{
    public PlayerActorIdleState(PlayerActorBehavior owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        ResetVelocity();
        Owner.ViewAnimator.Play("Idle");
    }
    
    public override Color GizmoColor()
    {
        return Color.grey;
    }
}
