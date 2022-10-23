using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGameOver : MonoBehaviour
{
    private GameObject gameOverDisplay;
    public GameObject crosshairDisplay;
    private Timer timerScript;
    public Text gameOverText;
    private GameObject fpsCamera;

    // Start is called before the first frame update
    void Start()
    {
        gameOverDisplay = GameObject.Find("_TimerManager");
        timerScript = gameOverDisplay.GetComponent<Timer>();
        crosshairDisplay = GameObject.Find("crosshairUI");
        fpsCamera = GameObject.Find("FirstPersonCharacter");
        Color transparent = new Color(0f, 0f, 0f, 0f);
        gameOverText.color = transparent;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerScript.timerClock == 0)
        {    
            gameOverText.text = "Game Over";
            gameOverText.color = Color.red;
            crosshairDisplay.GetComponent<RawImage> ().enabled=false;
            Time.timeScale = 0f; 
        }
    }
}
