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

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -1 * speed * Vector3.forward;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager coinManager = FindObjectOfType<CoinManager>();
            coinManager.CollectCoin();
            Destroy(gameObject);
        }
    }

    void CollectCoin()
    {
        Destroy(gameObject);
    }
}

