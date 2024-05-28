using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorWalkingState : PlayerActorGroundedState
{
    public PlayerActorWalkingState(PlayerActorBehavior owner) : base(owner)
    {
    }

    public override void PhysicsTick()
    {
        base.PhysicsTick();
        Owner.Rigidbody2D.AddForce((Owner.InputDirection.x * Owner.MoveSpeed) * Vector3.right - GetHorizontalVelocity(), ForceMode2D.Force);
    }

    public override Color GizmoColor()
    {
        return Color.blue;
    }
}
