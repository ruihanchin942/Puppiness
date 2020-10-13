using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullets : MonoBehaviour
{
    public float speed = 8f;
    public float lifetime = 2f;

    private float lifeTimer;

    void Start()
    {
        lifeTimer = lifetime;
    }

    void Update()
    {
        if (speed != 0)
        {
            transform.position += transform.forward * speed * Time.deltaTime;

            lifeTimer -= Time.deltaTime;
            if (lifeTimer <= 0f)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.Log("No Speed");
        }
    }
}
