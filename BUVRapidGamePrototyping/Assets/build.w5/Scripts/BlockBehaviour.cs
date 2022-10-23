using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public GameObject destroyedSmoke;
    public AudioClip blockDestruction;
    private Score scoreScript;
    private GameObject scoreManager;
    
    void Start()
    {
        scoreManager = GameObject.Find("_ScoreManager");
        scoreScript = scoreManager.GetComponent<Score>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "ammo")
            Destroy(col.gameObject);
            
        if (this.gameObject.tag == "Untagged")
        {
            this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
            this.gameObject.tag = "redBlock";
            scoreScript.UpdateScore(10);
        }
        else if (this.gameObject.tag == "redBlock")
        {
            this.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
            this.gameObject.tag = "yellowBlock";
            scoreScript.UpdateScore(25);
        }
        else if (this.gameObject.tag == "yellowBlock")
        {
            this.gameObject.GetComponent<Renderer> ().material.color = Color.green;
            this.gameObject.tag = "greenBlock";
            scoreScript.UpdateScore(50);
        }
        else if (this.gameObject.tag == "greenBlock")
        {
            Destroy(this.gameObject);
            //Instantiate(destroyedSmoke, this.transform.position, this.transform.rotation);
            AudioSource.PlayClipAtPoint(blockDestruction, this.transform.position);
            scoreScript.currentScore = 0;
        }
    }
}
