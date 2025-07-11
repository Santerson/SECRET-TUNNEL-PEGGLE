using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGravCap : MonoBehaviour
{
    [SerializeField] private float maxYSpeed = 10f;
    float currSpeed = 10f;
    [SerializeField] float stallTime = 1f;
    Rigidbody2D rb = null;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component is not attached to the GameObject. Please add it.");
        }
        StartCoroutine(startLate());
    }

    IEnumerator startLate()
    {
        currSpeed = 0;
        
        rb.velocity = Vector2.zero;
        yield return new WaitForSeconds(stallTime);
        currSpeed = maxYSpeed;
    }

    void Update()
    {
        if (currSpeed == 0)
        {
            transform.position = Vector2.zero;
            return;
        }
        if (rb == null)
        {
            return;
        }
        // Cap the vertical speed of the ball
        if (rb.velocity.y > currSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, currSpeed);
        }
        else if (rb.velocity.y < -currSpeed)
        {
            rb.velocity = new Vector2(rb.velocity.x, -currSpeed);
        }
    }
}
