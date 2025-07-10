using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPaddleMovment : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private float amplitude = 3f;


    // The original starting position of the object
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
       
        float xOffset = Mathf.Sin(Time.time * speed) * amplitude;

     
        transform.position = startPosition + Vector3.right * xOffset;
    }
}

