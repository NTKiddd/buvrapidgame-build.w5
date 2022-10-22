using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    public GameObject destroyedSmoke;
    public AudioClip blockDestruction;
    
    void Start()
    {

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
            }
            else if (this.gameObject.tag == "redBlock")
            {
                this.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
                this.gameObject.tag = "yellowBlock";
            }
            else if (this.gameObject.tag == "yellowBlock")
            {
                this.gameObject.GetComponent<Renderer> ().material.color = Color.green;
                this.gameObject.tag = "greenBlock";
            }
            else if (this.gameObject.tag == "greenBlock")
            {
                Destroy(this.gameObject);
                Instantiate(destroyedSmoke, this.transform.position, this.transform.rotation);
                AudioSource.PlayClipAtPoint(blockDestruction, this.transform.position);
            }
    }
}
