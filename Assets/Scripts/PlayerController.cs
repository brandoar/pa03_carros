using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controlador;
    public Vector3 direccion;
    public float gravedad = 9.8f;
    public float rotacion;
    public float salto = 50f;
    public float velocidad = 5f;
    public float velocidadRotacion = 3f;

    private string nombreArchivo = "basedatos.txt";
    private string contenidoArchivo = "Puntuacion";


    void Start()
    {
        controlador = gameObject.GetComponent<CharacterController>();

        //Guardar archivo plano en la carpeta Assets
        string rutaCompleta = Path.Combine(Application.dataPath, nombreArchivo);
        File.WriteAllText(rutaCompleta, contenidoArchivo);
    }

    // Update is called once per frame
    void Update()
    {
        if (controlador.isGrounded) {
            direccion = gameObject.transform.TransformDirection(new Vector3(Input.GetAxis("Vertical"), 0, 0) * velocidad);
            rotacion = Input.GetAxis("Horizontal") * velocidadRotacion;

            if (Input.GetKeyDown(KeyCode.Z)) {
                direccion.y += salto * Time.deltaTime * velocidad;
                controlador.transform.Rotate(Vector3.zero);
            }
        }

        direccion -= new Vector3(0, gravedad * Time.deltaTime, 0);
        controlador.transform.Rotate(new Vector3(0f, rotacion, 0f));
        controlador.Move(direccion * Time.deltaTime);
    }
}
