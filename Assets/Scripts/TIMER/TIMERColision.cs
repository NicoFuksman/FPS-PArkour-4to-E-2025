using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIMERColision : MonoBehaviour
{
    public TIMERMANAGER timerManager; // Drag and drop en el Inspector

    private void OnTriggerEnter (Collider collision)
    {
        Debug.Log("Colisión con: " + collision.gameObject.name);

        if (collision.gameObject.name == "StartTimer")
        {   
            timerManager.tiempoTranscurrido = 0f;
            timerManager.contadorEmpezo = true;
        }
        else if (collision.gameObject.name == "StopTimer")
        {
            timerManager.contadorEmpezo = false;
        }
    }
}