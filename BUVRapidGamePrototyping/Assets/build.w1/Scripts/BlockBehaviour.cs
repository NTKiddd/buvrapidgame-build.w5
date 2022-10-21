using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    
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
                Destroy(this.gameObject);
            }
    }
}
