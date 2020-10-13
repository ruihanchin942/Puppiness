using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    /* The Code Snippet (3. Player Shooting) was adapted from
     * https://www.youtube.com/watch?v=mpxim8YbsMk
     * https://www.youtube.com/watch?v=xenW67bXTgM&t=903s
     * https://www.youtube.com/watch?v=THnivyG0Mvo
     
    public float fireRate = 10f;
    public float damage = 10f;

    private Camera mainCam;

    private GameObject crosshair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BulletFired();
        }
    }

    void BulletFired()
    {
        RaycastHit hit;

        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit))
        {
            if (hit.transform.tag == Tags.ENEMY_TAG)
            {
                hit.transform.GetComponent<HealthScript>().TakeDamage(damage);
            }
        }
    }
    //End Code Snippet (3. Player Shooting)*/
}
