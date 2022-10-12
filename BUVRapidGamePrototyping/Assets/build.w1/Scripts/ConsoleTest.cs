using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleTest : MonoBehaviour

{
    private int ammo = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Inside the Start function");
        Debug.Log("Game has started. Reading ammo as " + ammo);
        ammo = ammo - 1;
        Debug.Log("Reading ammo as " + ammo);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Inside the Update function");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("LMB clicked");
            if(ammo>1)
            {
                ammo = ammo - 1;
                Debug.Log("You have " + ammo + " bullets remaining");
            }
            else if (ammo<1)
            {
                Debug.Log("You are out of ammo. Reload");
            }
        }
    }
}
