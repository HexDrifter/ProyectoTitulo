using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorGroundedState : PlayerActorLocomotionState
{
    public PlayerActorGroundedState(PlayerActorBehavior owner) : base(owner)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        Owner.ReusableData.timeInAir = 0;
    }
    public override void Tick()
    {
        base.Tick();
        Flip(Owner.InputDirection.x);
    }
}
