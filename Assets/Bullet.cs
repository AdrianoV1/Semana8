using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float lifetime = 10.0f;

    private float nextFireTime;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {

            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }
}
