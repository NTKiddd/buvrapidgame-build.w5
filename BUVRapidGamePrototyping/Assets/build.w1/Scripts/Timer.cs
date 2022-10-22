using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int timerClock = 10;

    IEnumerator timerCountdown()
    {
        while (timerClock > 0) 
        {
            yield return new WaitForSeconds(1.1f);
            timerClock = timerClock - 1;
            //Debug.Log("Time remaining: " + timerClock);
        }
    }

    void Start()
    {
        StartCoroutine(timerCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
