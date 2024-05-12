using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoTitulo.Framework
{
    public class PlayerActorBehavior : MonoBehaviour
    {
        [SerializeField] private string _id;
        [SerializeField] private Rigidbody2D _rigidbody2D;

        public string ID  => _id;
    }
}
