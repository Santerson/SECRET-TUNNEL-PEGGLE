using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPaddleMovment : MonoBehaviour
{

    [SerializeField]
    private float amplitude = 100f;

    bool goingRight = true;

    // The original starting position of the object
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }
    private void Update()
    {

        float xOffset = Mathf.Sin(Time.time * 1.2f) * amplitude;


        transform.position = startPosition + Vector3.right * xOffset;

        if (transform.position.x > 5.95f && goingRight)
        {
            GetComponent<SpriteRenderer>().flipX = true; // Face right
            goingRight = false;
        }
        else if (transform.position.x < -5.95f && !goingRight)
        {
            GetComponent<SpriteRenderer>().flipX = false; // Face left
            goingRight = true;
        }
    }
}

