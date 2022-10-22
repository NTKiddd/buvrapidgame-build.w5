using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    private GameObject tDisplay;
    private Timer timerScript;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        tDisplay = GameObject.Find("_TimerManager");
        timerScript = tDisplay.GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "Time:  " + timerScript.timerClock;

        if (timerScript.timerClock <= 5)
        {
            timerText.color = Color.red;
        }
    }
}
