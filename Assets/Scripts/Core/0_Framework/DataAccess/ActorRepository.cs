using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ProyectoTitulo.Framework
{
    using Domain;
    using Entities;

    public class ActorRepository : IActorRepository
    {

        private readonly Dictionary<string, Actor> _actors;

        public ActorRepository()
        {
            _actors = new Dictionary<string, Actor>();
        }
        public string Add(string baseID)
        {
            var entityID    = Guid.NewGuid().ToString();
            var actor       = new Actor(entityID, baseID);
            _actors         .Add(entityID, actor);
            return entityID;
        }

        public Actor Get(string entityID)
        {
            return _actors[entityID];
        }
    }
}
