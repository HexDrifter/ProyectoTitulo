using ProyectoTitulo.Domain;
using ProyectoTitulo.SystemUtilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMushroom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ServiceLocator.Instance.GetService<PickLife>().Pick(1);
            Destroy(gameObject);
        }
    }
}
