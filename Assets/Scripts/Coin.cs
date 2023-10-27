using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    private float lifetime = 10.0f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        rb.velocity = -1 * speed * Vector3.forward;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Timer coinManager = FindObjectOfType<Timer>();
            coinManager.CollectCoin();
            Destroy(gameObject);
        }
    }

    void CollectCoin()
    {
        Destroy(gameObject);
    }
}

