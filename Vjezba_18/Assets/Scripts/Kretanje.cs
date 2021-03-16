using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretanje : MonoBehaviour
{
    public float speed = 5f;
    public float speedJump = 300f;
    public bool jump = false;
    Vector2 maxVelocity = new Vector2(5, 5);
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float forceX = 0f;    
        float forceY = 0f;
        var absVelX = Mathf.Abs(rb.velocity.x);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!jump)
            {
                forceY = speedJump;
                jump = true;
            }
        } 
        Vector2 v2 = new Vector2(forceX, forceY);
        rb.AddForce(v2);
    }
    
}
