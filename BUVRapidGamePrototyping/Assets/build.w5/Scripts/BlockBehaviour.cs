using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public GameObject destroyedSmoke;
    public AudioClip blockDestruction;
    private Score scoreScript;
    private GameObject scoreManager;
    private GameObject blockFac;
    private BlockMaker blockmakerScript;

    void blockTagCheck()
    {
        GameObject[] gBlock;
        gBlock = GameObject.FindGameObjectsWithTag("greenBlock");

        if (gBlock.Length == blockTagCheck2())
        {
            Debug.Log("You win");
        }
    }

    int blockTagCheck2()   
    {
        return blockmakerScript.blockList.Count;    
    }

    void Start()
    {
        scoreManager = GameObject.Find("_ScoreManager");
        scoreScript = scoreManager.GetComponent<Score>();
        blockFac = GameObject.Find("_BlockFactory");
        blockmakerScript = blockFac.GetComponent<BlockMaker>();
    }

    void Update()
    {
    
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "ammo")
        {
            Destroy(col.gameObject);
                
            if (gameObject.tag == "greyBlock")
            {
                this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
                this.gameObject.tag = "redBlock";
                scoreScript.UpdateScore(10);
            }
            else if (gameObject.tag == "redBlock")
            {
                this.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
                this.gameObject.tag = "yellowBlock";
                scoreScript.UpdateScore(25);
            }
            else if (gameObject.tag == "yellowBlock")
            {
                this.gameObject.GetComponent<Renderer> ().material.color = Color.green;
                this.gameObject.tag = "greenBlock";
                scoreScript.UpdateScore(50);
                blockTagCheck();
            }
            else if (gameObject.tag == "greenBlock")
            {
                Destroy(gameObject);
                //Instantiate(destroyedSmoke, this.transform.position, this.transform.rotation);
                AudioSource.PlayClipAtPoint(blockDestruction, this.transform.position);
                scoreScript.currentScore = 0;
                blockmakerScript.blockList.Remove(this.gameObject); 
            }
        }
    }
}
