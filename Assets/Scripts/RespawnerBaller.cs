using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnerBaller : MonoBehaviour
{
    [SerializeField] GameObject respawnPS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        int lives = FindAnyObjectByType<LevelController>().SetLives(1);

        if (collision.gameObject.CompareTag("Ball"))
        {
            // Reset the position of the Baller to the starting position
            GameObject ps = Instantiate(respawnPS, collision.transform.position, Quaternion.identity);
            ps.GetComponentInChildren<ParticleSystem>().Play();
            yield return new WaitForSeconds(2);
            StartCoroutine(collision.gameObject.GetComponent<BallGravCap>().startLate());
            // Reset the velocity of the Baller
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = Vector2.zero;

            }
        }
    }


}
