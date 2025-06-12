using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public UIManager manager;
    void Start()
    {
        score = 0;
        manager = FindObjectOfType<UIManager>();
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
