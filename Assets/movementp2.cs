using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movementsp2 : MonoBehaviour

{
    public float speed = 5f; // Speed of the player movement
    public Rigidbody2D rb; // Reference to the Rigidbody component
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Vertical2");

        if (move != 0)
        {
            rb.velocity = new Vector2(0, move * speed);
        }

    }
}