using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ControlBola : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 direccion;
    public float velocidad;
    public float salto = 30;
    public float saltoUltimo, saltoDuracion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direccion = Vector3.zero;
        saltoUltimo = Time.time;
    }

    private void Update()
    {
        direccion = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (Input.GetButtonDown("Jump"))
        {
            if ((Time.time - saltoUltimo) > saltoDuracion) {
                direccion.y += salto;
                saltoUltimo = Time.time;
            }
        }

        rb.AddForce(direccion * velocidad * Time.deltaTime, ForceMode.Impulse);
    }

    void FixUpdate()
    {
        direccion = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rb.AddForce(direccion * velocidad * Time.deltaTime, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision objeto)
    {
        if (objeto.gameObject.tag == "cubo") {
            Destroy(objeto.gameObject);
        }
    }
}
