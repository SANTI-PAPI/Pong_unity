using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    private int direccionX, direccionY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        ChangeDirection();

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x ==0 && transform.position.y == 0)
        {
            rb.velocity = new Vector2(direccionX * speed, direccionY *speed);
        }

        
    }

    public void ChangeDirection()
    {
        direccionX= Random.Range(-1, 1);
        direccionY= Random.Range(-1, 1);
    }
}
