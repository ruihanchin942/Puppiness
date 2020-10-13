using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEvil : MonoBehaviour
{
    public Rigidbody enemy;

    // Start is called before the first frame update
    void Start()
    {    
        InvokeRepeating("LaunchEnemy", 2.0f, 5.0f);
    }

    void LaunchEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.Euler(0, 180, 0));
    }
}
