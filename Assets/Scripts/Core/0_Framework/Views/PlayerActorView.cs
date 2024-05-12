using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerActorView : BaseReactiveView
    {
        [SerializeField] private string _id;

        public string ID => _id;
    }
}
