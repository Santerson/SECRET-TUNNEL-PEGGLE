using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBall : MonoBehaviour
{
    [SerializeField] private GameObject TeleportExit = null;
    [SerializeField] ParticleSystem refParticles = null;
    [SerializeField] private AudioSource sfx;
    // Start is called before the first frame update
    void Start()
    {
        if (TeleportExit == null)
        {
            Debug.LogError("TeleportExit is not assigned in the inspector. Please assign a GameObject to it.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
        {
            Debug.LogError("collision is somehow equal to null");
            return;
        }
        if (collision.gameObject.CompareTag("Ball"))
        {
            //sfx.Play();
            // Teleport the ball to the other side of the screen
            collision.transform.position = TeleportExit.transform.position;
            FindObjectOfType<PegManager>().DeleteAllPegs();
            refParticles.Play();
        }
    }
}
