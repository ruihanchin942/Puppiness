using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShootScript : MonoBehaviour
{
    public GameObject chicken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryIndexTrigger") || Input.GetMouseButtonDown(0)){
             Instantiate(chicken, transform.position, transform.rotation);
         }
        
    }
}
