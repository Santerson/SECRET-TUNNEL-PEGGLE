using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnerBaller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Reset the position of the Baller to the starting position
            collision.transform.position = new Vector2(0f, 2f);
            // Reset the velocity of the Baller
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
