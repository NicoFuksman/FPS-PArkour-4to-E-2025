using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int health;
    public UIManager manager;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        manager = FindObjectOfType<UIManager>();
        manager.UpdateHealth(health);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetDamage()
    {
        health++;
        manager.UpdateHealth(health);
    }
    public void GetDamage(int damagePoints)
    {
        if (health + damagePoints > 0)
        {
            health += damagePoints;
            manager.UpdateHealth(health);
        }

        else if (health + damagePoints <= 0)
        {
            health += damagePoints;
            health = 0;
            manager.UpdateHealth(health);
            Debug.Log("Me mataron");
            SceneManager.LoadScene("Parkour");
        }
    }
}
