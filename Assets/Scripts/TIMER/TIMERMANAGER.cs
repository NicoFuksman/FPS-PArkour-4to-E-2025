using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TIMERMANAGER : MonoBehaviour
{

    [SerializeField] private TMP_Text timerText;

    public float tiempoTranscurrido;
    private int minutos;
    private int segundos;
    private int milesimas;

    public bool contadorEmpezo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void Update()

    {
        if (contadorEmpezo == true)
        {

        tiempoTranscurrido += Time.deltaTime;

        minutos = (int) (tiempoTranscurrido / 60f);
        segundos = (int) (tiempoTranscurrido - minutos * 60f);
        milesimas = (int)((tiempoTranscurrido - (int)tiempoTranscurrido) * 100f);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, milesimas);
        }

    }
}