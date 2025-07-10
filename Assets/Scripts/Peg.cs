using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    [SerializeField] public bool isKeyPeg = false;
    [SerializeField] private ParticleSystem hitParticles = null;
    [SerializeField] private AudioSource hitSound = null;
    private bool hit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hit) return;
        if (collision.gameObject.CompareTag("Ball"))
        {
            hit = true;
            FindObjectOfType<PegManager>().AddPeg(gameObject);
            if (isKeyPeg)
            {
                GetComponent<SpriteRenderer>().color = Color.green;
            }
            else
            { 
                GetComponent<SpriteRenderer>().color = Color.gray;
            }
            hitParticles.Play();
            hitSound.Play();
        }
    }

    public void PlayParticles()
    {
        hitParticles.Play();
    }
}
