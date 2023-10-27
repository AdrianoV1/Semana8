using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private float lifetime = 10.0f;

    private void Update()
    {

        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
