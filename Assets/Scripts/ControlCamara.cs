using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    private GameObject player;
    public Vector3 distancia;
    public float distanciaZ = -10f; // Ajusta la distancia en el eje Z
    public float suavizado = 5f;  // Ajusta este valor según tus necesidades


    void Start()
    {
        player = GameObject.Find("Player");
        distancia = new Vector3(1.2f, -4.94f, -4.97f);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = player.transform.position - distancia;
        // Calcula la nueva posición deseada de la cámara detrás del carro
            Vector3 nuevaPosicion = player.transform.position + new Vector3(0f, 5f, distanciaZ);

            // Aplica suavizado usando Lerp
            gameObject.transform.position = Vector3.Lerp(transform.position, nuevaPosicion, suavizado * Time.deltaTime);

            // Asegura que la cámara siempre mire hacia el carro
            transform.LookAt(player.transform);
    }
}
