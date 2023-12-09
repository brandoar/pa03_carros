using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaSalida : MonoBehaviour
{
    [SerializeField] private float tiempoEntreSalida;
    private float tiempoLineaSalida;
    private void OnColli(Collider2D collision)
    {
        Debug.Log("Hola, mundo player");

        if (collision.CompareTag("Player")) {
            Debug.Log("Hola, mundo player");

            tiempoLineaSalida -= Time.deltaTime;
            if (tiempoLineaSalida <= 0) { 
                
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hola, mundo player 2");
    }
}
