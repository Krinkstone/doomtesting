using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera RayCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    
    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(RayCam.transform.position, RayCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Enemy target = hit.transform.GetComponent<Enemy>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}