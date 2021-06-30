using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string escena;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            SceneManager.LoadScene(escena);
            Debug.Log(escena);
        }
        
    }
    public void Cambiar_Escena(string Escena) {
        SceneManager.LoadScene(Escena);
    }
}
