using UnityEngine;

public class SciFiHandGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Oculus_CrossPlatform_Button2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //muzzleFlash.Play();

        GameObject bulletObject = Instantiate(bulletPrefab);
        bulletObject.transform.position = transform.position + transform.forward;
        bulletObject.transform.forward = transform.forward;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        { 
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
