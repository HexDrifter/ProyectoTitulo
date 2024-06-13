using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorJumpingState : PlayerActorAirboneState
{
    public PlayerActorJumpingState(PlayerActorBehavior owner) : base(owner)
    {

    }
    public override void OnEnter()
    {
        Owner.Rigidbody2D.AddForce(Vector3.up * Owner.ReusableData.JumpForce, ForceMode2D.Impulse);
        Owner.ViewAnimator.Play("Jump");
    }

    public bool ShouldFall()
    {
        if(Owner.inputJump==false)
        {
            DecelerateVertically(1);
        }
        return Owner.Rigidbody2D.velocity.y < 0 && !Owner.ReusableData.isGrounded;
    }
    public override void PhysicsTick()
    {
        base.PhysicsTick();
        Owner.Rigidbody2D.AddForce((Owner.InputDirection.x * Owner.MoveSpeed) * Vector3.right - GetHorizontalVelocity(), ForceMode2D.Force);
    }

    public override Color GizmoColor()
    {
        return Color.green;
    }
}
