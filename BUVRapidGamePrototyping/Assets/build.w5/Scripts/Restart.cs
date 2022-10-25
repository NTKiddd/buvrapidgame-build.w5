using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameRestart()
    {
        //SceneManager.LoadScene("main");
        Destroy(GameObject.Find("_UiManager"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
