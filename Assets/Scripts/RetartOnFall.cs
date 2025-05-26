using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetartOnFall : MonoBehaviour
{
    public float yFallHeight;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yFallHeight)
        {
            Debug.Log("Me caí");
            SceneManager.LoadScene("Parkour");
        }        
    }
}
