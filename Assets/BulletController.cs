using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;

    private void Start()
    {

        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
