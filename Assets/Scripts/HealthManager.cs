using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    public UIManager manager;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        manager = FindObjectOfType<UIManager>();
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
        health += damagePoints;
        manager.UpdateHealth(health);
    }
}
