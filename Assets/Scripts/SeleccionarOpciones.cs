using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeleccionarOpciones : MonoBehaviour
{
    //private GameManager gameManager;
    private int index;

    private int carro;
    public GameObject menu_car;
    public GameObject menu_circuito;

    void Start()
    {
        menu_car.SetActive(true);
        menu_circuito.SetActive(false);
    }

    public void escogerCarro(int _carro)
    {
        carro = _carro;
        menu_car.SetActive(false);
        menu_circuito.SetActive(true);
    }

    public void escogerMapa(int _mapa)
    {
        if(_mapa == 1)
        {
            if (carro == 1) {
                SceneManager.LoadScene("JuegoCarro1");
            }

            if (carro == 2)
            {
                SceneManager.LoadScene("JuegoCarro2");
            }
        }

        if (_mapa == 2)
        {
            if (carro == 1)
            {
                SceneManager.LoadScene("JuegoCarro1");
            }

            if (carro == 2)
            {
                SceneManager.LoadScene("JuegoCarro2");
            }
        }
    }
}
