using ProyectoTitulo.Domain;
using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorLocomotionState : IState
{
    protected PlayerActorBehavior Owner;

    public PlayerActorLocomotionState(PlayerActorBehavior owner)
    {
        Owner = owner;
    }

    public virtual Color GizmoColor()
    {
        return Color.gray;
    }

    public virtual void OnEnter(){}
    public virtual void OnExit(){}
    public virtual void PhysicsTick(){}
    public virtual void Tick(){}

    protected void ResetVelocity()
    {
        Owner.Rigidbody2D.velocity = Vector3.zero;
    }
    public bool IsMovingHorizontally(float minimumMagnitude = 0.1f)
    {
        var horizontalVelocity = Owner.Rigidbody2D.velocity;
        return Mathf.Abs(horizontalVelocity.x) > minimumMagnitude;
    }

    protected void DecelerateHorizontally(float decelerateVelocity)
    {
        var horizontalVelocity = GetHorizontalVelocity();
        Owner.Rigidbody2D.AddForce(-horizontalVelocity * decelerateVelocity, ForceMode2D.Force);

    }
    protected Vector3 GetHorizontalVelocity()
    {
        var velocity = Owner.Rigidbody2D.velocity;
        velocity.y = 0;
        return velocity;
    }
}
