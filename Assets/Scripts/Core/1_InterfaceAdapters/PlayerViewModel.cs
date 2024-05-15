using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace ProyectoTitulo.InterfaceAdapters
{
    public class PlayerViewModel
    {
        public IntReactiveProperty Money;
        public IntReactiveProperty Lifes;

        public PlayerViewModel(int initialMoney, int initialLifes)
        {
            Money = new IntReactiveProperty(initialMoney);
            Lifes = new IntReactiveProperty(initialLifes);
        }
    }
}
