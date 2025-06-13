using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson; 


public class GravityColision : MonoBehaviour
{
    public Gravity gravityzone;
    public FirstPersonController gravity;
    // Start is called before the first frame update
    void Start()
    {
        gravityzone = FindObjectOfType<Gravity>();
        gravity = FindObjectOfType<FirstPersonController>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            gravity.m_GravityMultiplier = gravityzone.gravity;
            Debug.Log(gravityzone.gravity);
        }  
    }
    
    void OnTriggerExit (Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Debug.Log(gravityzone.gravity);
            gravity.m_GravityMultiplier = 2;
            Debug.Log("Salio del contacto: " + collider.gameObject.name);  
        }
    }
}
