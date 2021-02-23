using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;
    float moveVertical;
    //
    float moveHorizontal;
    public Rigidbody2D rb;
    private void Update() {
        moveHorizontal = Input.GetAxisRaw ("Horizontal");
        moveVertical = Input.GetAxisRaw ("Vertical");
    }
    private void FixedUpdate()
{  
   rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
}
}
