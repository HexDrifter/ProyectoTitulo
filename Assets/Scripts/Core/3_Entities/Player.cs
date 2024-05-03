using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Entities
{
    public class Player
    {
        
        public string activeActor {  get; private set; }

        public void SetActor(string actorEntityID)
        {
            this.activeActor = actorEntityID;
        }
    }
}
