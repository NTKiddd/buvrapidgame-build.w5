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
    public AudioClip emptyGun;
    bool canFire = true;
    private int ammo = 5;

    void shootingBullet()
    {
        Debug.Log("LMB clicked");
        Rigidbody bulletShot = Instantiate(bullet, this.transform.position, this.transform.rotation);
        bulletShot.AddRelativeForce(Vector3.forward * bulletForce);
        Destroy(bulletShot.gameObject, 5);
        AudioSource.PlayClipAtPoint(gunShot, this.transform.position);
    }

    void OnCollisionEnter (Collision ObjectCollidedWith)
    {
        if (ObjectCollidedWith.collider.tag == "wall")
        {
            Rigidbody bulletHit = bullet;
            Destroy(bulletHit.gameObject);
        }
    }

    IEnumerator ammoReload()
    {
        Debug.Log("Reloading...");
        AudioSource.PlayClipAtPoint(reload, this.transform.position);
        canFire = false;
        yield return new WaitForSeconds(3.3f);
        canFire = true;
        ammo = 5;
        Debug.Log("Reloaded. You have " + ammo + " bullets remaining");
    }

    void Start()
    {
        ammo = 5;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (canFire)
            {
                shootingBullet();

                if(ammo > 2)
                {
                    ammo = ammo - 1;
                    Debug.Log("You have " + ammo + " bullets remaining");
                }
                else if (ammo == 2)
                {
                    ammo = ammo - 1;
                    Debug.Log("You have 1 bullet remaining");
                }
                else
                {
                    ammo = 0;
                    Debug.Log("You are out of ammo. Press R to reload");
                    canFire = false;
                }
            }
            else
            {
                AudioSource.PlayClipAtPoint(emptyGun, this.transform.position);
                Debug.Log("You are out of ammo. Press R to reload");
            }

        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(ammoReload());
        }
    }
}


