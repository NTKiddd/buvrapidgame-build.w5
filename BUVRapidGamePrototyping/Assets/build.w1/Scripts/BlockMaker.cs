using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    public GameObject block;
    private int blockWidth = 2;
    private int blockHeight = 1;
    List<GameObject> blockList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BuildWall());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BuildWall()
    {
        //Instantiate(block, this.transform.position, Quaternion.identity);
        for (int xAxis = 0; xAxis < 5; xAxis++)
        {
            for (int yAxis = 0; yAxis < 5; yAxis++)
            {
                GameObject lastestBlock = Instantiate(block, new Vector3(this.transform.position.x + blockWidth * xAxis, this.transform.position.y + blockHeight * yAxis, this.transform.position.z), Quaternion.identity);

                //add blocks to the 'blockList' list
                blockList.Add(lastestBlock);
                //Debug.Log("Adding new block to the list. Reading element " + i + " as " + blockList[i]);
                yield return new WaitForSeconds(0.15f);
            }
        }
    }
}