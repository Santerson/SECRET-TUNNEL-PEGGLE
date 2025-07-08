using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    [SerializeField] private bool isKeyPeg = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<PegManager>().AddPeg(gameObject);
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }
}
