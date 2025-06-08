using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecciomDeColisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore();
        }
    }
}
