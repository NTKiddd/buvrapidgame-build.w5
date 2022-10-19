using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    //variable declarations
    public Rigidbody bullet;
    public int bulletForce;
    public AudioClip gunShot;
    public AudioClip reload;
    public AudioSource soundSource;
    bool canFire = true;
    
    // Start is called before the first frame update
    void Start()
    {
        soundSource.clip = reload;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("left click detected");
            Rigidbody bulletShot = Instantiate(bullet, this.transform.position, this.transform.rotation);
            bulletShot.AddRelativeForce(Vector3.forward * bulletForce);
            Destroy(bulletShot.gameObject, 5);
            AudioSource.PlayClipAtPoint(gunShot, this.transform.position);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            AudioSource.PlayClipAtPoint(reload, this.transform.position);
            if (soundSource.isPlaying)
            {
                Debug.Log("Reloading...");
            }
        }
    }
}


