using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private KeyCode K1Left = KeyCode.A;
    [SerializeField] private KeyCode K1Right = KeyCode.D;
    [SerializeField] private KeyCode k2Left = KeyCode.LeftArrow;
    [SerializeField] private KeyCode k2Right = KeyCode.RightArrow;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Vector2 startingPosition = new Vector2(0f, -4.5f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(K1Left) || Input.GetKey(k2Left) && transform.position.x > -6.1f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetKey(K1Right) || Input.GetKey(k2Right) && transform.position.x < 6.1f)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0f);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
