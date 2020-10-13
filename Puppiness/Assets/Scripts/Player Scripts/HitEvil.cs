using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEvil : MonoBehaviour
{
    /* The Code Snipper (4. Instantitate Prefab) was adapted from:
     * https://docs.unity3d.com/Manual/InstantiatingPrefabs.html
     */
    GameObject[] evilDog;
    EnemyController enemyControl;
    public GameObject puppy;


    // Start is called before the first frame update
    void Start()
    {
        evilDog = GameObject.FindGameObjectsWithTag("Enemy");
        enemyControl = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (gameObject != null)
        {
            foreach (GameObject e in evilDog)
            {
                if (other.gameObject == e.gameObject)
                {
                    Destroy(other.gameObject);
                    
                    Instantiate(puppy, transform.position, Quaternion.Euler(0, 180, 0));
                    Debug.Log("chicken touched dog");
                    
                    Destroy(gameObject);

                }
            }
        }
    }
    //End Code Snippet (4. Instantiate Prefab)
}
