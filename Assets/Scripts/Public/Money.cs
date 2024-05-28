using ProyectoTitulo.Domain;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ServiceLocator.Instance.GetService<PickMoney>().Pick(1);
            Destroy(gameObject);

        }
    }
}
