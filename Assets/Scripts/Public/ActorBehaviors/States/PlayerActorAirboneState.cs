using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorAirboneState : PlayerActorLocomotionState
{
    public PlayerActorAirboneState(PlayerActorBehavior owner) : base(owner)
    {
    }
    public override void Tick()
    {
        base.Tick();
        Owner.ReusableData.timeInAir += Time.deltaTime;
        Flip(Owner.InputDirection.x);
    }
}
