using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Interaccion : MonoBehaviour {

    public GameObject canvas;
    public Text Titulo;
    public Text info;
    public Image Imagen;

    public string[] Titulos;
    public string[] Informaciones;
    public Sprite[] Imagenes;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Target() {
        if (Input.GetMouseButtonDown(0) && !canvas.activeSelf)
        {
            Debug.Log("presionado");
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            Debug.Log(Input.mousePosition);
            RaycastHit objeto;
            if (Physics.Raycast(ray, out objeto)) {
                Debug.Log(objeto.transform.name);
                /// primer escena
                switch (objeto.transform.name) {
                    case "Glandula_Pituitaria_Cartel":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[0];
                        info.text = Informaciones[0];
                        Imagen.sprite = Imagenes[0];
                        break;
                    case "Glandula_Pituitaria_Cartel_2":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[1];
                        info.text = Informaciones[1];
                        Imagen.sprite = Imagenes[1];
                        break;
                    //// segunda escena
                    case "Foliculo_Cartel":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[0];
                        info.text = Informaciones[0];
                        Imagen.sprite = Imagenes[0];
                        break;
                    case "Foliculo_Cartel_2":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[1];
                        info.text = Informaciones[1];
                        Imagen.sprite = Imagenes[1];
                        break;
                        //// Tercera escena
                        case "Cartel_Ovulacion":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[0];
                        info.text = Informaciones[0];
                        Imagen.sprite = Imagenes[0];
                        break;
                    case "Cartel_Ovulacion_2":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[1];
                        info.text = Informaciones[1];
                        Imagen.sprite = Imagenes[1];
                        break;
                    case "Cartel_Ovulacion_3":
                        canvas.SetActive(true);
                        canvas.GetComponent<Canvas>().enabled = true;
                        Titulo.text = Titulos[2];
                        info.text = Informaciones[2];
                        Imagen.sprite = Imagenes[2];
                        break;

                }

            }

        }
    }

    // Update is called once per frame
    void Update() {
        Target();
        if (canvas.activeSelf) {
            Debug.Log("Canvas");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
      else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }
}
