using ProyectoTitulo.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActorStoppingState : PlayerActorGroundedState
{
    public PlayerActorStoppingState(PlayerActorBehavior owner) : base(owner)
    {
    }

    public override void PhysicsTick()
    {
        base.PhysicsTick();
        DecelerateHorizontally(Owner.ReusableData.DecelerationForce);
    }
}
