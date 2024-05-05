using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Entities
{
    public class Player
    {
        
        public string activeActor {  get; private set; }
        private List<string> _availableActors;
        public IReadOnlyList<string> availableActors => _availableActors;
        public Player()
        {
            _availableActors = new List<string>();
        }

        public void SetActor(string actorEntityID)
        {
            this.activeActor = actorEntityID;
        }

        public void AddActor(string actorEntityID)
        {
            _availableActors.Add(actorEntityID);
        }

        public void AddActor(List<string> actorsEntityIDs)
        {
            foreach (var actorID in actorsEntityIDs)
            {
                _availableActors.Add(actorID);

            }
        }
    }
}
