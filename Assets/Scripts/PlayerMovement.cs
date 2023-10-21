using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private List<Transform> laneReferences;

    private int currentLane;

    private Vector3 originalPosition;

    private float timer;
    
    void Start()
    {
        originalPosition = transform.position;
        currentLane = 1;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }

        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(originalPosition, laneReferences[currentLane].position, timer * 2);
    }

    void MoveLeft()
    {
        if (currentLane != 0 && timer>=0.5f)
        {
            currentLane--;
            timer = 0;
            originalPosition = transform.position;
        }
    }

    void MoveRight()
    {

        if (currentLane != 2 && timer >= 0.5f)
        {
            currentLane++;
            timer = 0;
            originalPosition = transform.position;
        }
    }
}
