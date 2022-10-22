using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentScore = 0;

    public void UpdateScore(int scoreToAdd)
    {
        currentScore = currentScore + scoreToAdd;
        Debug.Log("+" + scoreToAdd + " points");
    }

    void Start()
    {

    }

   
    void Update()
    {
        
    }
}
