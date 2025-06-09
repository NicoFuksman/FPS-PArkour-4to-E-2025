using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UIManager manager;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        manager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score ++;
        manager.UpdateScore(score);
    }
    public void AddScore(int scorePoints)
    {
        score += scorePoints;
        manager.UpdateScore(score);
    }
}
