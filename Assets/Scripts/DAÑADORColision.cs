using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAÑADORColision : MonoBehaviour
{
    public HealthManager healthManager;
    public Dañador dañador;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
        dañador = FindObjectOfType<Dañador>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            healthManager.GetDamage(dañador.damage);
        }
    }
}
