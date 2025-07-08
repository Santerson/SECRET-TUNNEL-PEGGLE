using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGravCap : MonoBehaviour
{
    [SerializeField] private float maxYSpeed = 10f;
    Rigidbody2D rb = null;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component is not attached to the GameObject. Please add it.");
        }   
    }

    void Update()
    {
        if (rb == null)
        {
            return;
        }
        // Cap the vertical speed of the ball
        if (rb.velocity.y > maxYSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxYSpeed);
        }
        else if (rb.velocity.y < -maxYSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, -maxYSpeed);
        }
    }
}
