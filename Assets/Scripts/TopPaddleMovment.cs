using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPaddleMovment : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;

    [SerializeField]
    private float amplitude = 100f;


    // The original starting position of the object
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }
    private void Update()
    {
       
        float xOffset = Mathf.Sin(Time.deltaTime * speed) * amplitude + 3;

     
        transform.position = startPosition + Vector3.right * xOffset;
    }
}

