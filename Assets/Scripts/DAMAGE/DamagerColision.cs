using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerColision : MonoBehaviour
{
    public HealthManager healthManager;
    public TheDamager damager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
        damager = FindObjectOfType<TheDamager>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            healthManager.GetDamage(damager.damage);
        }
    }
}
