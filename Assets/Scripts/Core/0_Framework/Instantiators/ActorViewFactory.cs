using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class ActorViewFactory
    {
        private readonly ActorViewFactoryConfiguration _configuration;

        public ActorViewFactory(ActorViewFactoryConfiguration configuration)
        {
            _configuration = configuration;
        }
        public PlayerActorView Create(string ID, Transform parent)
        {
            var viewInstance = Object.Instantiate(_configuration.Get(ID), parent);
            viewInstance.transform.localPosition = Vector3.zero;
            viewInstance.transform.localRotation = Quaternion.identity;

            return viewInstance;
        }
    }
}
