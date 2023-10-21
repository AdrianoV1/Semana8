using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> laneReferences;

    [SerializeField]
    private GameObject Prefab;

    [SerializeField]
    private float spawnTime;

    void Awake()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject obj = Instantiate(Prefab);
            Vector3 position = laneReferences[Random.Range(0,3)].position;
            position.z=transform.position.z;
            obj.transform.position = position;

            yield return new WaitForSeconds(spawnTime);
            
        }
    }

}
