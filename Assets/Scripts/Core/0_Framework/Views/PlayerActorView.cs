using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerActorView : BaseReactiveView
    {
        [SerializeField] private string _id;
        [SerializeField] private Animator _animator;
        
        public Animator Animator => _animator;

        public string ID => _id;
    }
}
