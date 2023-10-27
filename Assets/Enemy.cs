using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;

    private void Update()
    {

        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
