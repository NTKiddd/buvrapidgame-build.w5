using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private GameObject sDisplay;
    private Score scoreScript;
    public Text scoreText;
    private string scoreToDisplay;

    // Start is called before the first frame update
    void Start()
    {
        sDisplay = GameObject.Find("_ScoreManager");
        scoreScript = sDisplay.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Reading current score as " + scoreScript.currentScore);
        scoreText.text = "Score:  " + scoreScript.currentScore;
    }
}
