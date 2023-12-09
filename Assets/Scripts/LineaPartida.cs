using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineaPartida : MonoBehaviour
{
    public bool variableACambiar = false;

    /*private void OnCollisionEnter(Collision objeto)
    {
        if (objeto.gameObject.tag == "Player")
        {
            variableACambiar = true;
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            variableACambiar = true;
        }
    }
}
