using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UTILERIAColision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Utileria utileria; 
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        utileria = FindObjectOfType<Utileria>();
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
            scoreManager.AddScore(utileria.scorePoints);
        }
    }
}
