using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Entities
{
    public class Player
    {
        public int money {  get; private set; }
        public int lifes { get; private set; }
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

        public void AddMoney(int quantity)
        {
            money += quantity;

            if (money >= 100){
                var lifes = Mathf.FloorToInt(money / 100);
                money -= lifes * 100;
                AddLifes(lifes);
            }
        }
        public void AddLifes(int quantity)
        {
            lifes += quantity;
        }
    }
}
