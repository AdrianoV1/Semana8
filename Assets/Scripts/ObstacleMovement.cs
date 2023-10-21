using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    private float lifetime = 10.0f;

    void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        rb.velocity = Vector3.forward * -1 * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Derrota");
        }
    }
}
